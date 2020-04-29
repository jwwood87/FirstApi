using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CityInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            Console.ReadLine();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        static void ConsolePrinta (int i)
        {
            Console.WriteLine(i);
        }
    }
}
