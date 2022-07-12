using System;
using PostmanManager;
using Serilog;
using Serilog.Formatting.Compact;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- create the logger -----
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console(
                    theme: Serilog.Sinks.SystemConsole.Themes.AnsiConsoleTheme.Code
                )
                .WriteTo.File(
                    formatter: new CompactJsonFormatter(),
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug,
                    path: "PostmanCollectionManager_Log.log",
                    rollingInterval: RollingInterval.Infinite)
                .Enrich.FromLogContext()
                .CreateLogger();
            #endregion


            PostmanCollection collection = PostmanCollection.LoadCollection("Swagger Petstore.postman_collection.json");
            collection.Info.Name = "Modified Petstore Collection";
            collection.Info.PostmanId = Guid.NewGuid().ToString();
            PostmanCollection.SaveCollection(collection, "Swagger Petstore.postman_collection_Edited.json");
        }
    }
}
