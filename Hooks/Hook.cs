using Microsoft.Playwright;

namespace PlaywrightSpecFlowPOM.Hooks
{
    [Binding]
    public class Hooks
    {
        private static IBrowser? _browser;
        private static IBrowserContext? _context;
        public static IPage Page { get; private set; } = null!;

        [BeforeScenario] // -> Notice how we're doing these steps before each scenario
        public static async Task InitializeBrowser()
        {
            //Initialise Playwright
            var playwright = await Playwright.CreateAsync();
            //Initialise a browser - 'Chromium' can be changed to 'Firefox' or 'Webkit'
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false // -> Use this option to be able to see your test running
            });
            //Setup a browser context
            _context = await _browser.NewContextAsync();
           
            //Initialise a page on the browser context.
            Page = await _context.NewPageAsync();
        }
        
        [AfterScenario]
        public static async Task AfterScenario()
        {
          await Page?.CloseAsync()!;
        }
        
    }
}