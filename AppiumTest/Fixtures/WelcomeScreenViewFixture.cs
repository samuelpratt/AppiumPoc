using System.Collections.Generic;
using OpenQA.Selenium;

namespace AppiumTest.Fixtures
{
    class WelcomeScreenViewFixture : AbstractViewFixture
    {
        private static readonly string SignInString = "Sign in";
        private static readonly string RegisterString = "Create an account";

        public WelcomeScreenViewFixture(DriverWrapper driver) : base(driver, new List<By> { By.Name(SignInString), By.Name(RegisterString) } )
        {
        }

        public void ClickSignIn()
        {
            ClickElement(By.Name(SignInString));
        }

        public void ClickRegister()
        {
            ClickElement(By.Name(RegisterString));
        }
    }
}
