using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.Specflow.PageObjects
{
    public class AlpacaDetailSPageObjects
    {

        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];

        public AlpacaDetailSPageObjects()
        {
            PageFactory.InitElements(_driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "*//*[contains(@class, 'field--name-field-lange-naam')]")]
        public IWebElement FullName { get; set; }
    }
}
