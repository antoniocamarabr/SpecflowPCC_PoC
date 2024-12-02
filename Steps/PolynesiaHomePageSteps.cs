using System.Reflection.Metadata;
using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightSpecFlowPOM.Pages;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class PolynesiaHomePageSteps
{
    private readonly IPage _page;
    private readonly PolynesiaHomePage _polynesiaGoHomePage;

    public PolynesiaHomePageSteps(Hooks.Hooks page, PolynesiaHomePage polynesiaGoHomePage)
    {
        _page = Hooks.Hooks.Page;
        _polynesiaGoHomePage = polynesiaGoHomePage;
    }

    [Given(@"I navigate to the Polynesia homepage")]
    public async Task GivenINavigateToThePolynesiaHomepage()
    {
        //Go to the Polynesia homepage
        await _page.GotoAsync("https://www.polynesia.com//");

    }

    [When(@"I wait the page loads")]
    public async Task WhenIWaitThePageLoads()
    {
       Console.WriteLine("Hello World");
       await _page.WaitForTimeoutAsync(1500);
       await _polynesiaGoHomePage.ShopPolynesiaBar.IsVisibleAsync();
    }

    [Then(@"I am able to see the Win a Free Trip to Hawai popup")]
    public async Task ThenIAmAbleToSeeThePopupToWinAFreeTripToHawai()
    {
        await _polynesiaGoHomePage.WinFreeTripHawaiPopup.IsVisibleAsync();
    }
    
    [Then(@"I verify the popup text '(.*)'")]
    public async Task IVerifyThePopupTextFreeTripToHawai(string popupTitle)
    {
        var titleText = _polynesiaGoHomePage.PopupWinFreeTripHawaiText;
        await Assertions.Expect(titleText).ToContainTextAsync(popupTitle);
    }

    [Then(@"I am able to close the Win a Free Trip to Hawai popup")]
    public async Task IAmAbleToCloseTheWinAFreeTripToHawaiPopup()
    {
        await _page.EvaluateAsync("document.body.style.zoom=0.9");
        await _polynesiaGoHomePage.PopupCloseButton.DispatchEventAsync("click");
    }
    
    [Then(@"I am able to see in shop area '(.*)' and '(.*)' labels")]
    public async Task ThenIAmAbleToSeeInShopAreaAndLabels(string shopIslandGift, string shopPolynesia)
    {
        //Assert the shop area content
        var shopIslandGiftsText = _polynesiaGoHomePage.ShopIslandGiftsLabel;
        var shopPolynesiaText = _polynesiaGoHomePage.ShopPolynesiaLabel;
        
        await Assertions.Expect(shopIslandGiftsText).ToContainTextAsync(shopIslandGift);
        await Assertions.Expect(shopPolynesiaText).ToContainTextAsync(shopPolynesia);

    }

    [Then(@"I am able to see in language area '(.*)' idiom")]
    public async Task ThenIAmAbleToSeeInLanguageAreaIdiom(string idiom)
    {
        //Assert the language area content
        var languageText = await _polynesiaGoHomePage.LanguageAreaDropdown.TextContentAsync();
        Console.WriteLine("Language Text: " +languageText);
        Console.WriteLine("Idiom Parameter: " +idiom);
        Assert.IsTrue(languageText != null && languageText.Contains(idiom));
    }

}