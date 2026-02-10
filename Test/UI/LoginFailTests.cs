using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using Microsoft.Playwright;
using NUnit.Framework;
using playwrightExample.Core.Api;
using playwrightExample.Core.Base;
using playwrightExample.Core.Browser;

namespace playwrightExample.Test.UI
{
    [TestFixture]
    public class LoginFailTests : BaseTest
    {
        private IPage _page;

        [SetUp]
        public void TestSetup()
        {
            _page = (IPage)Driver;
        }
        [Test]
        public async Task Login_Fail_Test()
        {
            await _page.GotoAsync("https://automationexercise.com/");

            var signButton = _page.Locator("//a[@href='/login']");

            await signButton.ClickAsync(new LocatorClickOptions { Button = MouseButton.Left });

            await _page.WaitForTimeoutAsync(2000);

            var emailField = _page.Locator("//input[@data-qa='login-email']");
            var passwordField = _page.Locator("//input[@data-qa='login-password']");
            var submitBtn = _page.Locator("//button[@data-qa='login-button']");

            await emailField.FillAsync("test1@gmail.com");
            await passwordField.FillAsync("test1");

            await _page.WaitForTimeoutAsync(5000);

            await submitBtn.ClickAsync(new LocatorClickOptions { Button = MouseButton.Left });

            var errorMsn = _page.Locator("//form[@action='/login']//p");

            var text = await errorMsn.InnerTextAsync();

            await _page.WaitForTimeoutAsync(2000);
            Assert.That(text, Is.EqualTo("Your email or password is incorrect!"));
        }
    }
}