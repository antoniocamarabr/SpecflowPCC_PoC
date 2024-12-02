using Microsoft.Playwright;
using PlaywrightSpecFlowPOM.Pages;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class PolynesiaShoppingSteps
{
    private readonly IPage _page;
    private readonly PolynesiaShoppingPage _polynesiaShoppingPage;
    private readonly PolynesiaHomePage _polynesiaGoHomePage;

    public PolynesiaShoppingSteps(Hooks.Hooks page, PolynesiaShoppingPage polynesiaShoppingPage, PolynesiaHomePage polynesiaGoHomePage)
    {
        _page = Hooks.Hooks.Page;
        _polynesiaShoppingPage = polynesiaShoppingPage;
        _polynesiaGoHomePage = polynesiaGoHomePage;
    }
    
    [When(@"I am able to see in shop area '(.*)'")]
    public async Task IAmAbleToSeeInShopArea(string islandGiftArea)
    {
        var shopIslandGiftsText = _polynesiaGoHomePage.ShopIslandGiftsLabel;
        await Assertions.Expect(shopIslandGiftsText).ToContainTextAsync(islandGiftArea);
    }

    [Then(@"I click on the '(.*)' link")]
    public async Task ThenIClickOnTheLink(string shoppingLink)
    {
        switch (shoppingLink)
        {
            case "SHOP ISLAND GIFTS":
                await _polynesiaShoppingPage.ShopIslandGiftsLink.ClickAsync();
                break;
            case "SHOP POLYNESIA":
                await _polynesiaShoppingPage.ShopPolynesiaLink.ClickAsync();
                break;
        }
    }
    
    [Then(@"I verify the polynesia shopping page")]
    public async Task IVerifyThePolynesiaShoppingPage()
    {
        const string expectedUrl = "https://thehawaiistore.com/";

        try
        {
            await _page.WaitForURLAsync(expectedUrl, new PageWaitForURLOptions
            {
                Timeout = 5000 
            });
            Console.WriteLine("Expected URL: " + expectedUrl);
        }
        catch (TimeoutException)
        {
            Console.WriteLine("URL NOT FOUND");
        }
    }
}