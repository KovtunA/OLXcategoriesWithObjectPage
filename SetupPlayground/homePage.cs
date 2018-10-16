using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SetupPlayground
{
    public class homePage
    {
        IWebDriver browser;
        string homePageURL = "https://www.olx.ua";

        [FindsBy(How = How.CssSelector, Using = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(2) > div")]
        public IWebElement realestateCategory;

        [FindsBy(How = How.CssSelector, Using = "#bottom1 > div > a")]
        public IWebElement showRealestate;

        [FindsBy(How = How.CssSelector, Using = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(3) > div > a")]
        public IWebElement carCategory;

        [FindsBy(How = How.CssSelector, Using = "#bottom1532 > div > a")]
        public IWebElement showCars;

        [FindsBy(How = How.CssSelector, Using = "#headerLogo")]
        public IWebElement logoButton;

        public homePage(IWebDriver browser)
        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }

        public void open()
        {
            browser.Navigate().GoToUrl(homePageURL);
        }

        public void openRealestatePage()
        {
            realestateCategory.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            showRealestate.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void openCarsPage()
        {
            carCategory.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            showCars.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
