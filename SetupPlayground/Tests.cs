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
        public void RealestatePage()
        { homePage.openRealestatePage(); }

        [Test]
        public void carsPage()
        { homePage.openCarsPage(); }

        [Test]
        public void kidsPage()
        { homePage.openKidsPage();  }


        [Test]
        public void SparePartPage()
        { homePage.openSparePartsPage(); }

        [Test]
        public void WorkPage()
        { homePage.openWorkPage(); }


        [Test]
        public void AnimalPage()
        { homePage.openAnimalPage(); }

        [Test]
        public void housePage ()
        { homePage.openHousePage(); }

        [Test]
        public void GadgetsPage()
        { homePage.openGadgetsPage(); }

        [Test]
        public void BusinessPage()
        { homePage.openBusinessPage(); }

        [Test]
        public void FashionPage()
        { homePage.openFashionPage(); }

        [Test]
        public void HobbyPage()
        { homePage.openHobbyPage(); }

        [Test]
        public void ForFreepage()
        { homePage.openForfreePage(); }


        //[Test]
        //public void obmen()
        //{
        //    IWebDriver browser = new ChromeDriver();
        //    browser.Navigate().GoToUrl("https://www.olx.ua");
        //    IWebElement categoria = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(16) > div.li.fleft > div > a > span:nth-child(1)"));
        //    categoria.Click();
        //    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    browser.Close();
        //}

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