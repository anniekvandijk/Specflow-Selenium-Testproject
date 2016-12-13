using SpecflowSelenium.Specflow.PageObjects;

namespace SpecflowSelenium.Specflow.Pages
{
    class AlpacamundoHomePage
    {
        AlpacamundoHomePageObjects _pageObjects = new AlpacamundoHomePageObjects();

    public void SelectMenuItemOnzeAlpacaS()
        {
            _pageObjects.MenuItemOnzeAlpacaS.Click();
        }
    }
}
