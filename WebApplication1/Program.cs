using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using HospitalDB.Entities;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class Program
    {
        //Get a database context instance from the dependency injection container.
        //Call the seed method, passing to it the context.
        //Dispose the context when the seed method is done.

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
