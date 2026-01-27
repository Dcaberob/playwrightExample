using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace playwrightExample.Core.Browser
{
    public static class SeleniumFactory
    {
        public static IWebDriver Create()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");

            // Para CI:
            // options.AddArgument("--headless=new");

            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }
    }
}
