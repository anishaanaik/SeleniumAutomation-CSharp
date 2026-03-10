using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace SeleniumAutomation
{
    internal class Program
    {
        static String browser ="chrome";
        static IWebDriver? driver;
        static void Main(string[] args)
        {
            if(browser.Equals("chrome"))
            {
                driver=new ChromeDriver();
            }
            else if(browser.Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            if (browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
           // driver.Url = "https://mail.google.com/mail/u/0/#inbox";
            
            driver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/#inbox");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(15));
            
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Title.Length);
            //IWebElement username = driver.FindElement(By.Name("identifier"));
            //username.SendKeys("dfdfd@gmail.com");

            driver.FindElement(By.Name("identifier")).SendKeys("anvitanaik2024@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button/span")).Click();

            // wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"next\"]/div/div/a"));
            IWait<IWebDriver> wait1 = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(30),
                PollingInterval = TimeSpan.FromSeconds(5)
            };
            wait.IgnoreExceptionTypes(typeof(ElementNotInteractableException));
            
            driver.FindElement(By.XPath("//*[@id=\"next\"]/div/div/a")).Click();
            driver.Close();
              
        }
    }
}
