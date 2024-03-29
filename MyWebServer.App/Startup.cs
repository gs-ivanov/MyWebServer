﻿namespace MyWebServer.App
{
    using System.Threading.Tasks;
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.App.Controllers;
    using MyWebServer.App.Data;
    using MyWebServer.Results.Views;

    public class Startup
    {
        public static async Task Main()
            => await HttpServer
                .WithRoutes(routes => routes
                    .MapStaticFiles()
                    .MapControllers()
                    .MapGet<HomeController>("/ToCats", c => c.LocalRedirect()))
                .WithServices(services => services
                    .Add<IViewEngine,CompilationViewEngine>()
                    .Add<IData, MyDbContext>())
                .Start();
        // Submited as start of Exampreparation
    }
}
