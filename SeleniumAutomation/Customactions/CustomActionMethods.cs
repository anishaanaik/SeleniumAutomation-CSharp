using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASel
{
    public static class SeleniumCustomMethods
    {
        public static void Click(this IWebElement locator)
        {
            locator.Click();
        }
        public static void SubmitE(this IWebElement locator)
        {
            locator.Submit();
        }
        public static void ClearEnterText(this IWebElement locator, String text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }
         
        public static void SelectDropDownByText(this IWebElement locator, String text)
        {
           SelectElement se=new SelectElement(locator);
            se.SelectByText(text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, String value)
        {
            SelectElement se = new SelectElement(locator);
            se.SelectByValue(value);
        }


    }
}
