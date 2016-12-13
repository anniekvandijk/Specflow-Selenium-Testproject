using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.Specflow.PageObjects
{
    class AlpacamundoHomePageObjects
    {

        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];

        public AlpacamundoHomePageObjects()
        {
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Onze alpaca's")]
        public IWebElement MenuItemOnzeAlpacaS;
    }
}
