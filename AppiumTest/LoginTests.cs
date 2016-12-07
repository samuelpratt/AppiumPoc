using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppiumTest.Fixtures;

namespace AppiumTest
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void NoSession_OpenApp_IntegrityWarningIsDisplayed()
        {
            using (var driver = new DriverFactory().GetDriver())
            {
                var integrityWarningFixture = new IntegrityWarningViewFixture(driver);

                Assert.IsTrue(integrityWarningFixture.IsDisplayed());
            }
        }

        [TestMethod]
        public void NoSession_AcceptRoot_WelcomeScreenIsDisplayed()
        {
            using (var driver = new DriverFactory().GetDriver())
            {
                var integrityWarningFixture = new IntegrityWarningViewFixture(driver);
                var welcomeScreenFixture = new WelcomeScreenViewFixture(driver);

                integrityWarningFixture.ClickAccept();
                welcomeScreenFixture.WaitForDisplay();

                Assert.IsTrue(welcomeScreenFixture.IsDisplayed());
                
                
            }
        }

        [TestMethod]
        public void NoSession_TapSignIn_SignInScreenIsDisplayed()
        {
            using (var driver = new DriverFactory().GetDriver())
            {
                var integrityWarningFixture = new IntegrityWarningViewFixture(driver);
                var welcomeScreenFixture = new WelcomeScreenViewFixture(driver);
                var signinFixture = new SignInViewFixture(driver);

                integrityWarningFixture.ClickAccept();
                welcomeScreenFixture.WaitForDisplay();
                welcomeScreenFixture.ClickSignIn();
                signinFixture.WaitForDisplay();

                Assert.IsTrue(signinFixture.IsDisplayed());


            }
        }

        [TestMethod]
        public void NoSession_CorrectCredentials_SignedInOK()
        {
            using (var driver = new DriverFactory().GetDriver())
            {
                var integrityWarningFixture = new IntegrityWarningViewFixture(driver);
                var welcomeScreenFixture = new WelcomeScreenViewFixture(driver);
                var signinFixture = new SignInViewFixture(driver);

                integrityWarningFixture.ClickAccept();
                welcomeScreenFixture.WaitForDisplay();
                welcomeScreenFixture.ClickSignIn();
                signinFixture.WaitForDisplay();

                signinFixture.SignIn(Credentials.Username, Credentials.Password);
            }
        }
    }
}
