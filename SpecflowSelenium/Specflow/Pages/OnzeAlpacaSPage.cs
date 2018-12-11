using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecflowSelenium.Specflow.PageObjects;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.Specflow.Pages
{
    class OnzeAlpacaSPage
    {
        OnzeAlpacaSPageObjects _pageObjects = new OnzeAlpacaSPageObjects();
        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];

        public void SelectAlpaca(string name)
        {
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            _pageObjects.Link(name).Click();
        }
    }
}
