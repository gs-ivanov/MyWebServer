namespace MyWebServer.App
{
    using MyWebServer;
    using MyWebServer.App.Controllers;
    using MyWebServer.Controllers;
    using System.Threading.Tasks;

    public class Startup
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
                .MapStaticFiles()
                .MapControllers()
                .MapGet<HomeController>("/ToCats",c=>c.LocalRedirect()))
            .Start();

        //.MapGet<HomeController>("/", c => c.Index())
        //.MapGet<HomeController>("/ToCats", c => c.LocalRedirect())
        //.MapGet<HomeController>("/Softuni", c => c.ToSoftUni())
        //.MapGet<HomeController>("/Error", c => c.Error())
        //.MapGet<HomeController>("/StaticFiles", c => c.StaticFiles())
        //.MapGet<AnimalsController>("/Cats", c => c.Cats())
        //.MapGet<AnimalsController>("/Dogs", c => c.Dogs())
        //.MapGet<AnimalsController>("/Bunnies", c => c.Bunnies())
        //.MapGet<AnimalsController>("/Turtles", c => c.Turtles())
        //.MapGet<AccountController>("/Login", c => c.Login())
        //.MapGet<AccountController>("/Logout", c => c.Logout())
        //.MapGet<AccountController>("/Cookies", c => c.CookiesCheck())
        //.MapGet<AccountController>("/Session", c => c.SessionCheck())
        //.MapGet<AccountController>("/Authentication", c => c.AuthenticationCheck())
        //.MapGet<CatsController>("/Cats/Create", c => c.Create())


    }
}
