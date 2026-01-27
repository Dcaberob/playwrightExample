using Microsoft.Playwright;

namespace playwrightExample.Core.Browser
{
    public static class PlaywrightFactory
    {
        public static IPage Create()
        {
            // Crear Playwright
            var playwright = Playwright.CreateAsync().GetAwaiter().GetResult();

            // Lanzar navegador
            var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Channel = "chrome",
                Headless = false
            }).GetAwaiter().GetResult();


            // Crear contexto
            var context = browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = null,
                IgnoreHTTPSErrors = true
            }).GetAwaiter().GetResult();

            // Crear página
            var page = context.NewPageAsync().GetAwaiter().GetResult();

            return page;
        }
    }
}
