using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace Recipes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseServer("Microsoft.AspNetCore.Server.Kestrel")
                        .UseUrls("http://*:5000")
                        .UseApplicationBasePath(Directory.GetCurrentDirectory())
                        .UseDefaultConfiguration(args)
                        .UseIISPlatformHandlerUrl()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}