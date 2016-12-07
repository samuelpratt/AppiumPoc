using System.Configuration;

namespace AppiumTest.Fixtures
{
    class Credentials
    {
        public static string Username => ConfigurationManager.AppSettings["Username"];
        public static string Password => ConfigurationManager.AppSettings["Password"];
    }
}
