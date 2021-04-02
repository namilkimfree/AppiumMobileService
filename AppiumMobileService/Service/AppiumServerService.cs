using System;
using System.IO;
using OpenQA.Selenium.Appium.Service;

namespace AppiumMobileService.Service
{
    public class AppiumServerService : IAppiumServerService
    {
        private AppiumLocalService _localService;

        public Uri ServerAddress => _localService?.ServiceUrl;

        public void Dispose()
        {
            _localService?.Dispose();

            _localService = null;
        }

        public void ServerStart()
        {
            _localService = new AppiumServiceBuilder().UsingAnyFreePort().Build();

            _localService.Start();
        }

        public void ServerStop()
        {
            _localService.Dispose();
        }

        public bool IsStarted() => _localService.IsRunning;

        public Uri ServerUri() => ServerAddress;
    }
}