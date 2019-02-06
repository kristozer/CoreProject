using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CoreProject.Models;

namespace CoreProject
{
    public class Program
    {
        public static void Main(string[] args)=>
        //{
            /*/var host =*/ CreateWebHostBuilder(args)
                    .Build()
                    .Run();
           /*  using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<Context>();
                }
                catch(Exception ex)
                {
                    
                }
            }
            host.Run();*/
       // }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
