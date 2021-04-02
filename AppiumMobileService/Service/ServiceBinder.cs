using System;
using System.ComponentModel.Design;
using System.IO;
using AppiumMobileService.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppiumMobileService.Service
{
    public class ServiceBinder
    {
        protected readonly IConfiguration Configuration;
        protected readonly IServiceProvider ServiceProvider;

        public ServiceBinder()
        {
            var environment = Environment.GetEnvironmentVariable("KIOSK_ENVIRONMENT");

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environment}.json")
                .Build();

            var appConfig = Configuration.GetSection("AppiumOptions").Get<GlobalConfig>();


            ServiceProvider = new ServiceCollection()
                .AddSingleton<IAppiumService, AppiumService>()
                .AddSingleton<IAppiumServerService, AppiumServerService>()
                .BuildServiceProvider();
        }


        public T GetService<T>()
        {
            var service = ServiceProvider.GetService<T>();

            return service;
        }
    }
}