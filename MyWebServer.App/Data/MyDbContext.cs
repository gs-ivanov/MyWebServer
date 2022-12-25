namespace MyWebServer.App.Data
{
    using MyWebServer.App.Data.Models;
    using System.Collections.Generic;
    public class MyDbContext : IData
    {
        public MyDbContext()
            => this.Cats = new List<Cat>
            {
                new Cat{Id=1,Name="Sharo",Age=5},
                new Cat{Id=2,Name="Lady",Age=13}
            };

        public IEnumerable<Cat> Cats { get; }
    }
}
}
