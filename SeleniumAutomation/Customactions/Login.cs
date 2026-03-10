using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASel.Pages
{
    internal class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));
        IWebElement UserName => driver.FindElement(By.Id("UserName"));
        IWebElement PassWord => driver.FindElement(By.Id("Password"));

        IWebElement LoginBtn => driver.FindElement(By.CssSelector(".btn"));

        public void ClickLogin()
        {
            LoginLink.Click();
            //SeleniumCustomMethods.Click(LoginLink);
        }

        public void Login(String userTxt, String password)
        {

            //UserName.SendKeys(userTxt);
            //PassWord.SendKeys(password);

            //SeleniumCustomMethods.ClearEnterText(UserName, userTxt);
            //SeleniumCustomMethods.ClearEnterText(PassWord, password);
            //SeleniumCustomMethods.Submit(LoginBtn);

            UserName.ClearEnterText(userTxt);
            PassWord.ClearEnterText(password);
            LoginBtn.SubmitE();
        }


    }
}
