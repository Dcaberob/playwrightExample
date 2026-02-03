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

            var nameField = _page.Locator("//input[@name='name']");
            var emailField = _page.Locator("//input[@data-qa='signup-email']");
            var submitBtn = _page.Locator("//button[@data-qa='signup-button']");

            await nameField.FillAsync("test1");
            await emailField.FillAsync("cabernaldo010788@gmail.com");

            await _page.WaitForTimeoutAsync(5000);

            await submitBtn.ClickAsync(new LocatorClickOptions{ Button = MouseButton.Left});

            await _page.WaitForTimeoutAsync(5000);

            var titleBtn = _page.Locator("#id_gender1");

            await titleBtn.ClickAsync(new LocatorClickOptions{ Button= MouseButton.Left});

            var passwordField = _page.Locator("#password");

            await passwordField.FillAsync("Test123");

            var dayField = _page.Locator("#days");
            var monthField = _page.Locator("#months");
            var yearField = _page.Locator("#years");

            await dayField.SelectOptionAsync(new SelectOptionValue{ Label = "1"});
            await monthField.SelectOptionAsync(new SelectOptionValue{ Label = "July"});
            await yearField.SelectOptionAsync(new SelectOptionValue{ Label = "1988"});

            var newsletterCheck = _page.Locator("#newsletter");
            var partnersCheck = _page.Locator("#optin");

            await newsletterCheck.ClickAsync(new LocatorClickOptions{ Button = MouseButton.Left});
            await partnersCheck.ClickAsync(new LocatorClickOptions{ Button = MouseButton.Left});

            await _page.WaitForTimeoutAsync(5000);

            var firstNameField = _page.Locator("#first-name");
            var lastNameField = _page.Locator("#last-name");
            var companyField = _page.Locator("#company");
            var addressField = _page.Locator("#address1");
            var countrySelect = _page.Locator("#country");
            var stateField = _page.Locator("#country");

            //Assert.That(_page.Url, Does.Contain("automationexercise.com/login"));
        }
    }
}
