using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace LearningSeriLog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureLogging(loggingConfiguration =>
            loggingConfiguration.ClearProviders())
            .UseSerilog((hostingContext, loggerConfiguration) =>
            loggerConfiguration.ReadFrom
            .Configuration(hostingContext.Configuration));
    }
}
