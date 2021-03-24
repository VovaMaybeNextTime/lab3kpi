using lab3.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab3
{
    class LoginPage : BaseObject
    {

        private const string LOGIN_PAGE_LINK = "//*[@id=\"common_menu\"]/div/div[1]/div[1]/a[1]";
        private const string EMAIL_FIELD = "login";
        private const string PASSWORD_FIELD_ID = "id_password";
        private const string LOGIN_BUTTON = "//*[@id=\"jsc-submit-button-a922-f3e1-\"]/button";
        private const string MODAL_WINDOW = "//*[@id=\"jsc-error-message-block-d3d6-f892-\"]/div/div";


        [FindsBy(How = How.XPath, Using = LOGIN_PAGE_LINK)]
        public IWebElement loginLink;

        [FindsBy(How = How.Name, Using = EMAIL_FIELD)]
        public IWebElement emailField;

        [FindsBy(How = How.Id, Using = PASSWORD_FIELD_ID)]
        public IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = LOGIN_BUTTON)]
        public IWebElement loginBtn;

        public static LoginPage GetLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            InitPage(loginPage);
            return loginPage;
        }

        public LoginPage GoToLoginPage()
        {
            loginLink.Click();
            Thread.Sleep(3000);
            return GetLoginPage();

        }

        public LoginPage PrintEmail(string email)
        {
            emailField.SendKeys(email);
            return GetLoginPage();
        }

        public LoginPage PrintPassword(string password)
        {
            passwordField.SendKeys(password);
            return GetLoginPage();
        }

        public StartPage ClickLoginBtn()
        {
            loginBtn.Click();
            return StartPage.GetStartPage();
        }

        public LoginPage AssertIncorrectModal()
        {
            Thread.Sleep(9000);
            Driver.FindElement(By.XPath(MODAL_WINDOW));
            return this;
        }


    }
}
