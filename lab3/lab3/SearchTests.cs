using lab3.TestHelpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestFixture]
    class SearchTests : BaseTest
    {
        private static SearchHelper searchHelper = new SearchHelper();
        [Test]
        public void ShowTipsTest()
        {
            string searchRequest = "asd\n";

            searchHelper.Search(searchRequest)
                .AssertTipsIsPresent();
        }

        [Test]
        public void SearchIsCorrectTest()
        {
            string searchRequest = "zxc\n";

            searchHelper.Search(searchRequest)
                .AssertProductListIsShown();
        }

        [Test]
        public void SearchIsNotSuccessfullTest()
        {
            string searchRequest = "fghtdtyj\n";

            searchHelper.Search(searchRequest)
                .AssertMeesage();
        }
    }
}
