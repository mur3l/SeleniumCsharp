using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace SHOP_KinderGarten_TEST
{
    [TestFixture]
    public class KinderGartenTEST
    {
        private IWebDriver driver;
        private string baseUrl = "https://localhost:7282/";

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            //Maximize, et kõik oleks visuaalselt nähtav
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void TestNavigateToKindergartenPage()
        {
            driver.Url = baseUrl;

            //Leia link visuaalse elemendi (teksti) järgi
            IWebElement kindergartenLink = driver.FindElement(By.LinkText("Kindergarten"));

            kindergartenLink.Click();
            Thread.Sleep(500);

            Assert.That(driver.Url, Does.Contain("/Kindergarten"));
        }

        [Test]
        public void TestAddKindergarten_ValidData()
        {
            driver.Url = baseUrl;
            driver.FindElement(By.Id("kindergarten")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.Id("testIdAdd")).CLick;

        }

    }
}
