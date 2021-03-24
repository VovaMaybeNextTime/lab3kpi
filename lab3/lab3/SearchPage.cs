using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab3.Pages
{
    public class SearchPage : BaseObject
    {

        private const string SEARCH_PAGE_LINK = "/html/body/div[1]/div/div[2]/div/ul/li[7]/a/span";
        private const string SEARCH_PAGE_LINK_2 = "/html/body/div[1]/div/div[2]/div/ul/li[7]/div/ul/li[3]/a";
        private const string SEARCH_FIELD_ID = "account_table_search";
        private const string QUICK_LINKS= "#masthead > div.header-main.header-contents.has-center.menu-center > div > div.header-right-items.header-items > div.header-search.icon > div";
        private const string PRODUCT_RESULT_LIST = "/html/body/div[1]/div/div[4]/div[2]/div[1]/div[2]/table";
        private const string SEARCH_IS_NOT_SUCCESFULL_MSG_CLASS = "b-search-result";

        [FindsBy(How = How.XPath, Using = SEARCH_PAGE_LINK)]
        public IWebElement searchPageLink;
        
        [FindsBy(How = How.XPath, Using = SEARCH_PAGE_LINK_2)]
        public IWebElement searchPageLink2;

        [FindsBy(How = How.Id, Using = SEARCH_FIELD_ID)]
        public IWebElement searchField;


        public static SearchPage GetSearchPage()
        {
            SearchPage searchPage = new SearchPage();
            InitPage(searchPage);
            return searchPage;
        }

        public SearchPage GoToSearchPage()
        {
            searchPageLink.Click();
            searchPageLink2.Click();
            return GetSearchPage();  
        }

        public SearchPage PrintSerchRequest(string searchRequest)
        {
            searchField.SendKeys(searchRequest);
            return GetSearchPage();
        }

        public SearchPage AssertTips()
        {
            Thread.Sleep(2000);
            Driver.FindElement(By.CssSelector(QUICK_LINKS));
            return GetSearchPage();
        }

        public SearchPage AssetsSearchList()
        {
            
            Driver.FindElement(By.XPath(PRODUCT_RESULT_LIST));
            return GetSearchPage();
        }

        public SearchPage AssetsUnseccesfullSearchMsg()
        {
            Driver.FindElement(By.ClassName(SEARCH_IS_NOT_SUCCESFULL_MSG_CLASS));
            return GetSearchPage();
        }
    }
}
