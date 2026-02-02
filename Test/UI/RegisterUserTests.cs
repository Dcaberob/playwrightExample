using System.Reflection.Metadata;
using Microsoft.Playwright;
using NUnit.Framework;
using playwrightExample.Core.Base;
using playwrightExample.Core.Browser;

namespace playwrightExample.Test.UI
{
    [TestFixture]
    public class RegisterUserTests : BaseTest
    {

        private IPage _page;

        [SetUp]
        public void TestSetup()
        {
            _page = (IPage)Driver;
        }


        [Test]
        public async Task Resgister_User()
        {
            
            await _page.GotoAsync("https://automationexercise.com/");

            var signButton = _page.Locator("//a[@href='/login']");

            await signButton.ClickAsync(new LocatorClickOptions{ Button= MouseButton.Left});

            await _page.WaitForTimeoutAsync(2000);

            Assert.That(_page.Url, Does.Contain("automationexercise.com/login"));
        }
    }
}
