using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.Specflow.PageObjects
{
    class OnzeAlpacaSPageObjects
    {

        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];

        public OnzeAlpacaSPageObjects()
        {
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Jesse")]
        public IWebElement LinkJesse;
    }
}
