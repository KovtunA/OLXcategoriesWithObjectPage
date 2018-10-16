using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SetupPlayground
{
    [TestFixture]
    public class Class1
    {
        IWebDriver browser;
        homePage homePage;
        private IWebElement logoButton;

        [OneTimeSetUp]
        public void openBrowser()
        { browser = new ChromeDriver(); }

        [SetUp]
        public void prepare()
        {
            homePage = new homePage(browser);
            homePage.open();
        }

        [Test]
        public void RealestatePag()
        {
            homePage.openRealestatePage();
        }

        [Test]
        public void carsPage()
        {
            homePage.openCarsPage();
        }

        [TearDown]
        public void returnToMainPage()
        {
            homePage.logoButton.Click();
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            browser.Close();
        }
    }
}