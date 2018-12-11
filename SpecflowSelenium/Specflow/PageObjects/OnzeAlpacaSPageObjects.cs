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
        public IWebElement Link(string name)
        {
            return _driver.FindElement(By.LinkText(name));
        }
    }
}
