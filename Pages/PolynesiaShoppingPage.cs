using Microsoft.Playwright;

namespace PlaywrightSpecFlowPOM.Pages;


public class PolynesiaShoppingPage
{
    private readonly IPage _page;

    public PolynesiaShoppingPage()
    {
        _page = Hooks.Hooks.Page;
    }
    
    public ILocator ShopIslandGiftsLink => _page.Locator("[class='topbar__link topbar__link--giving']");
    public ILocator ShopPolynesiaLink => _page.Locator("[class='topbar__link topbar__link--shop']");
}