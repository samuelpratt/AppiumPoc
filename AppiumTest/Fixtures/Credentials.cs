using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumTest.Fixtures
{
    class Credentials
    {
        public static string Username => ConfigurationManager.AppSettings["Username"];
        public static string Password => ConfigurationManager.AppSettings["Password"];
    }
}
