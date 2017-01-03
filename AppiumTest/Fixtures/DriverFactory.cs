using System;
using System.Configuration;
using OpenQA.Selenium.Remote;

namespace AppiumTest.Fixtures
{
    public class DriverFactory
    {
        public DriverWrapper GetDriver()
        {
            var driver = new DriverWrapper(GetUri(), GetDesiredCapabilities());
            WaitForAppToInitilise(driver);
            return driver;
        }

        private static void WaitForAppToInitilise(DriverWrapper driver)
        {
            var integityFixture = new IntegrityWarningViewFixture(driver);
            integityFixture.WaitForDisplay(10000);
        }

        private Uri GetUri()
        {
            return new Uri("http://127.0.0.1:4723/wd/hub");
        }

        private DesiredCapabilities GetDesiredCapabilities()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability("appActivity", "com.oyster.MainActivity");
            capabilities.SetCapability("fullReset", "true");
            return capabilities;
        }
    }
}