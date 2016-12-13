using SpecflowSelenium.Specflow.PageObjects;

namespace SpecflowSelenium.Specflow.Pages
{
    class OnzeAlpacaSPage
    {
        OnzeAlpacaSPageObjects _pageObjects = new OnzeAlpacaSPageObjects();

    public void SelectJesse()
        {
            _pageObjects.LinkJesse.Click();
        }
    }
}
