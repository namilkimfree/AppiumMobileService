using System;
using AppiumMobileService.Helpers;
using OpenQA.Selenium.Appium;

namespace AppiumMobileService.Service
{
    public class AppiumService : IAppiumService
    {
        private const int NewCommandTimeoutSeconds = 120;
        private readonly TimeSpan AppiumDriverStartupTimeout = TimeSpan.FromSeconds(180);

        public AppiumDriver<AppiumWebElement> Driver { get; private set; }

        public PlatformEnum Platform { get; set; }

        public bool IsOnIOS => Platform == PlatformEnum.iOS;

        public bool IsOnAndroid => Platform == PlatformEnum.Android;

        public string PlatformSpecificNewLine => IsOnIOS ? "\n" : "\r";


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public AppiumDriver<AppiumWebElement> InitDriverService()
        {
            throw new NotImplementedException();
        }

        public AppiumOptions MakeDriverOptions()
        {
            throw new NotImplementedException();
        }

        public void CloseDriverService()
        {
            throw new NotImplementedException();
        }
    }
}