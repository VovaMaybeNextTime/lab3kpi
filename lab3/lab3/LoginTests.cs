using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestFixture]
    class LoginTests : BaseTest
    {
        private static LoginHelper loginHelper = new LoginHelper();

        [Test]
        public static void CorrectLoginTest()
        {
            string email = "pro1001111111@bk.ru";
            string password = "Vova28042001";

            string expectedUserName = "NaVi_strelok_iz_kustov";

            loginHelper
                .Login(email, password)
                .AssertUserName(expectedUserName);
        }


        [Test]
        public static void InCorrectLoginTest()
        {
            string email = "pro1001111111@bk.ru";
            string password = "rthgthgfh";

            loginHelper
                .Login(email, password)
                .AssertIncorrectData();
        }
    }
}
