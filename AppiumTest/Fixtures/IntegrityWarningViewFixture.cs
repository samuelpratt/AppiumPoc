using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.Fixtures
{
    class IntegrityWarningViewFixture : AbstractViewFixture
    {
        private static readonly string AcceptString = "I know and it is ok for me";
        private static readonly string LogoutString = "Log out and clear data";

        public IntegrityWarningViewFixture(AndroidDriver<AndroidElement> driver) : base(driver, new List<By> { By.Name(AcceptString), By.Name(LogoutString) } )
        {
        }

        public void ClickAccept()
        {
            ClickElement(By.Name(AcceptString));
        }

        public void ClickLogout()
        {
            ClickElement(By.Name(LogoutString));
        }
    }
}