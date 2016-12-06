using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.Fixtures
{
    class SignInViewFixture : AbstractViewFixture
    {
        private static readonly string SignInString = "Sign in";
        private static readonly string EmailString = "Email";

        public SignInViewFixture(AndroidDriver<AndroidElement> driver) : base(driver, new List<By> { By.Name(EmailString), By.Name(SignInString) })
        { }

        public void SignIn(string email, string password)
        {
            ClickElement(By.Name(EmailString));
            var keyboard = Driver.Keyboard;
            keyboard.SendKeys(email);
            Driver.PressKeyCode(AndroidKeyCode.Enter);
            keyboard.SendKeys(password);
            Driver.PressKeyCode(AndroidKeyCode.Enter);
        }
    }
}
 