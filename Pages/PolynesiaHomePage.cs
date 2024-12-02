using Microsoft.Playwright;

namespace PlaywrightSpecFlowPOM.Pages;

public class PolynesiaHomePage
{
    private readonly IPage _page;

    public PolynesiaHomePage()
    {
        _page = Hooks.Hooks.Page;
    }

    public ILocator PopupCloseButton => _page.Locator("[class='exit-popup']");
    public ILocator ShopPolynesiaBar => _page.Locator("[class='topbar__container']");
    public ILocator ShopIslandGiftsLabel => _page.Locator("[class='topbar__link topbar__link--giving']");
    public ILocator ShopPolynesiaLabel => _page.Locator("[class='topbar__link topbar__link--shop']");
    public ILocator LanguageAreaDropdown => _page.Locator("[class='topbar-menu']");
    public ILocator WinFreeTripHawaiPopup => _page.Locator("#lb-text");
    public ILocator PopupWinFreeTripHawaiText => _page.Locator("[id='lb-text'] p[class='header']");
}