using Microsoft.Playwright;
using NUnit.Framework;
using playwrightExample.Core.Base;
using playwrightExample.Core.Browser;

namespace playwrightExample.Test.UI
{
    [TestFixture]
    public class OpenPageTests : BaseTest
    {
        [Test]
        public async Task Open_Page_With_Playwright()
        {
            var page = (IPage)Driver;

            await page.GotoAsync("https://automationexercise.com/");

            Assert.That(page.Url, Does.Contain("automationexercise.com"));

            await page.CloseAsync();
        }
    }
}
