using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "https://www.demoqa.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}