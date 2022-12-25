namespace MyWebServer.App.Data
{
    using MyWebServer.App.Data.Models;
    using System.Collections.Generic;
    public interface IData
    {
        IEnumerable<Cat> Cats { get; }
    }
}
