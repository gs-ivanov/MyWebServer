namespace MyWebServer.Controllers
{
    using MyWebServer.Http;
    using MyWebServer.Routing;
    using System;
    public static class RoutingTableExtensions
    {
        public static IRoutingTable MapGet<TController>(
             this IRoutingTable routingTable,
            string path,
            Func<TController, HttpResponse> controllerFunction)
            where TController : Controller
            => routingTable.MapGet(path, HttpRequest => controllerFunction(
                CreateController<TController>(HttpRequest)));

        public static IRoutingTable MapPost<TController>(
            this IRoutingTable routingTable,
            string path,
            Func<TController, HttpResponse> controllerFunction)
            where TController : Controller
            => routingTable.MapPost(path, HttpRequest => controllerFunction(
                CreateController<TController>(HttpRequest)));



        private static TController CreateController<TController>(HttpRequest request)
            => (TController)Activator.CreateInstance(typeof(TController), new[] { request });


    }
}
