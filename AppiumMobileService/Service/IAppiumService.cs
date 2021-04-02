using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace AppiumMobileService.Service
{
    public interface IAppiumService :  IDisposable 
    {
        AppiumDriver<AppiumWebElement> InitDriverService();
        AppiumOptions MakeDriverOptions();

        void CloseDriverService();
    }
}