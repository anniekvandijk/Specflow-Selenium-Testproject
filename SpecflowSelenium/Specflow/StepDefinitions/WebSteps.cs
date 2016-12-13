using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
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
        
        [When(@"ik klik op Jesse")]
        public void AlsIkKlikOpJesse()
        {
            _alpacaSPage.SelectJesse();
        }
        
        [Then(@"zie ik de details van Jesse")]
        public void DanIkDeDetailsVanJesse()
        {
            Assert.AreEqual("Alpacamundo Jesse", _alpacaDetailPage.FullName());
        }
    }
}
