using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApplication1
{ 
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://toolsqa.com/";
        }
    }
}