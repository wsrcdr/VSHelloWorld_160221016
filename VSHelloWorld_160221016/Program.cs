using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace VSHelloWorld_160221016
{
    public class Program
    {
<<<<<<< HEAD
        // Roberto Ressurreição
=======
        //Bruno Teixeira - again
>>>>>>> 0c109a96c34b13f80c4634d2c92c27a222f7d18d
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
