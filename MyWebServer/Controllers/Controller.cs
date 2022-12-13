namespace MyWebServer.Controllers
{
    using MyWebServer.Http;
    using MyWebServer.Responses;
    using MyWebServer.Results;
    using System.Runtime.CompilerServices;

    public abstract class Controller
    {
        protected Controller(HttpRequest request)
        {
            this.Request = request;

            this.Response = new HttpResponse(HttpStatusCode.OK);
        }

        protected HttpRequest Request { get; private init; }

        protected HttpResponse Response { get; private init; }

        protected ActionResult Text(string text)
            => new TextResult(this.Response,text);

        protected HtmlResponse Html(string html)
            => new HtmlResponse(html);

        protected HttpResponse Redirect(string location)
            => new RedirectResponse(location);

        protected HttpResponse View([CallerMemberName] string viewName = "")
            => new ViewResponse(viewName, this.GetControllerName(), null);

        protected HttpResponse View(string viewName, object model)
                   => new ViewResponse(viewName, this.GetControllerName(), model);

        protected HttpResponse View(object model,[CallerMemberName] string viewName="")
                   => new ViewResponse(viewName, this.GetControllerName(), model);

        private string GetControllerName()
            => this.GetType().Name
            .Replace(nameof(Controller), string.Empty);
    }
}
