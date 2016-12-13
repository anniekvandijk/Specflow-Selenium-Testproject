using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.Specflow.PageObjects
{
    class AlpacaDetailSPageObjects
    {

        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];

        public AlpacaDetailSPageObjects()
        {
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.XPath, Using = "*//h2[text()='Alpacamundo Jesse']")]
        public IWebElement Header2Jesse;
    }
}
