namespace MyWebServer.App
{
    using System.Threading.Tasks;
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.App.Controllers;
    using MyWebServer.App.Data;

    public class Startup
    {
        public static async Task Main()
            => await HttpServer
            .WithRoutes(routes => routes
                .MapStaticFiles()
                .MapControllers()
                .MapGet<HomeController>("/ToCats", c => c.LocalRedirect()))
            .WithServices(services=>services
                .Add<IData,MyDbContext>())
            .Start();
        //class Foo
        //{
        //    public int A { get; set; }
        //    public string B { get; set; }
        //    public bool T { get; set; }

        //    public void Show()
        //    {
        //        System.Console.WriteLine(8888);
        //    }
        //}
        //public static void Main()
        //{
        //    System.Console.WriteLine(9999);

        //    Foo foo = new Foo { A = 999, B = "Hi!!" ,T=true};

        //    foreach (var prop in foo.GetType().GetProperties())
        //    {
        //        System.Console.WriteLine($"{prop.Name} = {prop.GetValue(foo,null)}");
        //    }
        //}
        //public static async Task Main()
        //    => await new HttpServer(routes => routes
        //        .MapStaticFiles()
        //        .MapControllers()
        //        .MapGet<HomeController>("/ToCats", c => c.LocalRedirect()))
        //    .Start();

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
