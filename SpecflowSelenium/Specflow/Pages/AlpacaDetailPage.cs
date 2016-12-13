using SpecflowSelenium.Specflow.PageObjects;

namespace SpecflowSelenium.Specflow.Pages
{
    class AlpacaDetailPage
    {
        AlpacaDetailSPageObjects _pageObjects = new AlpacaDetailSPageObjects();

    public string FullName()
        {
            return _pageObjects.Header2Jesse.Text;
        }
    }
}
