using System;
using OpenQA.Selenium.Appium.Service;

namespace AppiumMobileService.Service
{
    public interface IAppiumServerService : IDisposable
    {
        void ServerStart();
        void ServerStop();
        bool IsStarted();
        Uri ServerUri();
        


    }
}