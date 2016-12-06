using System;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AppiumTest.Fixtures
{
    public class DriverWrapper : AndroidDriver<AndroidElement>, IDisposable
    {
        public DriverWrapper(Uri uri, DesiredCapabilities capabilities) : base(uri, capabilities)
        {
            
        }

        private bool _disposed;
        public new void Dispose()
        {
            if (_disposed) return;
            Quit();
            _disposed = true;
            base.Dispose(_disposed);
        }
    }
}