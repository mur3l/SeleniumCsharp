using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        public void OpenAppTest()
        {
            driver.Url = "https://www.demoga.com";
        }
        public void EndTest()
        {
            driver.Close();
        }
    }
}