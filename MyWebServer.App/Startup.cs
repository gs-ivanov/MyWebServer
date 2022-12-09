namespace MyWebServer.App
{
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.App.Controllers;
    using System.Threading.Tasks;

    public class Startup
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
            .MapGet<AnimalsController>("/Cats", c => c.Cats())
            .MapGet<AnimalsController>("/Dogs", c => c.Dogs())
            .MapGet<AnimalsController>("/Bunnies", c => c.Bunnies())
            .MapGet<AnimalsController>("/Turtles", c => c.Turtles())
            .MapGet<CatsController>("/Cats/Create", c => c.Create())
            .MapGet<CatsController>("/Cats/Save", c => c.Save()))
            .Start();

    }
}