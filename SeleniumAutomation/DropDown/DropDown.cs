using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace DropDown
{
    internal class Program
    {
        static String browser = "chrome";
        static IWebDriver driver;
        static void Main(string[] args)
        {
            switch (browser)
            {
                case "chrome":
                    driver=new ChromeDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    Console.WriteLine("Enter valid browser name:");
                    break;
            }
            driver.Url = "https://www.wikipedia.org/";
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            // driver.FindElement(By.XPath("//*[@id="searchLanguage"]")).SendKeys("Eesti");

            //IWebElement dropDown = driver.FindElement(By.XPath("//*[@id=\"searchLanguage\"]"));
            //SelectElement select = new SelectElement(dropDown);
            //select.SelectByText("Eesti");
            //var values = driver.FindElements(By.TagName("option"));
            //Console.WriteLine("Total values are:"+values.Count);
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.Text+" ---value is:"+value.GetAttribute("value"));
            //}

            //var links = driver.FindElements(By.TagName("a"));
            //Console.WriteLine("Total links are:" + links.Count);
            //foreach (var link in links)
            //{
            //    Console.WriteLine(link.Text+" ---Link url is:" + link.GetAttribute("href"));
            //}

            IWebElement dropDown = driver.FindElement(By.XPath("//*[@id=\"searchLanguage\"]"));
            SelectElement select = new SelectElement(dropDown);
            select.SelectByText("Eesti");

            var values = dropDown.FindElements(By.TagName("option"));
            Console.WriteLine("Total values are:"+values.Count);

            IWebElement section =driver.FindElement(By.XPath("//*[@id=\"www-wikipedia-org\"]/footer/nav"));
            var sectionLinks= section.FindElements(By.TagName("a"));
            foreach(var slink in sectionLinks)
            {
                Console.WriteLine(slink.Text+"-----value is"+slink.GetAttribute("href"));
            }
        }
    }
}
