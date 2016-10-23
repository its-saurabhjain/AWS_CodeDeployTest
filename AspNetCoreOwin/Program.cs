using System;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Server.Kestrel;
//using Microsoft.AspNetCore.Server.WebListener;
//using Microsoft.AspNetCore.Server.IISIntegration;
using System.IO;

namespace AspnetCoreWithOwinHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string uri = "http://localhost:3000/";
            var host = new WebHostBuilder()
                .UseKestrel()
                //.UseWebListener()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}
