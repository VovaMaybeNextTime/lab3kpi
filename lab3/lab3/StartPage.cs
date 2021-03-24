using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class StartPage : BaseObject
    {
        private const string NOT_LOGIN_PAGE = "//*[@id=\"common_menu\"]/div/div[1]/div[1]/a[2]/span[3]";

        [FindsBy(How = How.XPath, Using = NOT_LOGIN_PAGE)]
        public IWebElement not_login_page;

        public static StartPage GetStartPage()
        {
            StartPage startPage = new StartPage();
            InitPage(startPage);
            return startPage;
        }

        public StartPage AssertUserName(string expectedUserName)
        {
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(NOT_LOGIN_PAGE.Replace("#", expectedUserName)));
            return GetStartPage();
        }
    }
}
