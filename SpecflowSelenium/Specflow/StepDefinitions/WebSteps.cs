using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using SpecflowSelenium.Specflow.Pages;

namespace SpecflowSelenium.Specflow.StepDefinitions
{
    [Binding]
    public class WebSteps
    {

        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];
        private readonly AlpacamundoHomePage _homePage = new AlpacamundoHomePage();
        private readonly OnzeAlpacaSPage _alpacaSPage = new OnzeAlpacaSPage();
        private readonly AlpacaDetailPage _alpacaDetailPage = new AlpacaDetailPage();

        [Given(@"ik ben op de site van Alpacamundo")]
        public void GegevenIkBenOpDeSiteVanAlpacamundo()
        {
            _driver.Navigate().GoToUrl("http://www.alpacamundo.eu");
        }
        
        [When(@"ik in het menu ga naar Onze alpaca's")]
        public void AlsIkInHetMenuGaNaarOnzeAlpacaS()
        {
            _homePage.SelectMenuItemOnzeAlpacaS();
        }
        
        [When(@"ik klik op '(.*)'")]
        public void AlsIkKlikOpJesse(string name)
        {
            _alpacaSPage.SelectAlpaca(name);
        }

        [When(@"ik klik op functietoetsen")]
        public void AlsIkKlikOpFunctietoets()
        {
            // Actions werken niet in Firefox met gecko driver
            Actions actions = new Actions(_driver);
            actions.SendKeys(Keys.PageDown).Perform();
            actions.SendKeys(Keys.PageUp).Perform();
            // Onderstaande werken niet in Chrome. 
            actions.SendKeys(Keys.F5);
            actions.KeyDown(Keys.LeftAlt).SendKeys(Keys.ArrowLeft).Perform();
         }

        [Then(@"zie ik de volledige alpaca naam '(.*)'")]
        public void DanIkDeDetailsVan(string name)
        {
            Assert.AreEqual(name, _alpacaDetailPage.FullName());
        }
    }
}
