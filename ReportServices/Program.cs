using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReportServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseContentRoot(Directory.GetCurrentDirectory())
            //    .UseIISIntegration()
            //    .UseStartup<Startup>()
            //    .UseUrls("http://0.0.0.0:6000")
            //    .Build();

            //host.Run();

            var host = new WebHostBuilder()
               .UseKestrel().UseKestrel(options =>
               {
                   options.Limits.MaxRequestBodySize = long.MaxValue;
               })
               .UseContentRoot(Directory.GetCurrentDirectory())
               //.UseIISIntegration()
               .UseStartup<Startup>()
               .UseUrls("http://0.0.0.0:6000")
               .Build();

            host.Run();
        }

       
    }
}
