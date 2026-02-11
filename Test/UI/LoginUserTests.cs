using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Playwright;
using playwrightExample.Core.Base;
using playwrightExample.Core.Api;

namespace playwrightExample.Test.UI
{
    [TestFixture]
    public class LoginUserTests : BaseTest
    {
        private IPage _page;
        private ApiClient apiClient;

        [SetUp]
        public async Task TestSetupAsync()
        {
            _page = (IPage)Driver;
            apiClient = new ApiClient();
            
            var body = new Dictionary<string, string>
            {
                {"name" , "Daniel"},
                {"email" , "cabernaldo010788@gmail.com"}, // evita duplicados
                {"password" , "Test123"},
                {"title" ,"Mr"},
                {"birth_date" , "10"},
                {"birth_month" , "5"},
                {"birth_year" , "1990"},
                {"firstname" , "Daniel"},
                {"lastname" , "Cabero"},
                {"company" , "QA Corp"},
                {"address1" , "Street 123"},
                {"address2" , "Apt 1"},
                {"country" , "Bolivia"},
                {"zipcode", "0000"},
                {"state" , "LP"},
                {"city" , "La Paz"},
                {"mobile_number" , "77777777"}
            };
            
             var response = apiClient.PostForm("/api/createAccount", body);

            var responseBody = response.Result;
            //Console.WriteLine(responseBody);       

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

            await emailField.FillAsync("cabernaldo010788@gmail.com");
            await passwordField.FillAsync("Test123");

            await _page.WaitForTimeoutAsync(5000);

            await submitBtn.ClickAsync(new LocatorClickOptions { Button = MouseButton.Left });

            var logoutBtn = _page.Locator("//a[@href='/logout']");

            await logoutBtn.ClickAsync(new LocatorClickOptions{Button = MouseButton.Left});
            await _page.WaitForTimeoutAsync(2000);

            Assert.That(_page.Url, Does.Contain("automationexercise.com/login"));
        }

         [TearDown]
        public async Task DeleteUser()
        {
            HttpClient _client = new HttpClient();
            string urlEndpoint = "https://automationexercise.com/api/deleteAccount";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", "cabernaldo010788@gmail.com"),
                new KeyValuePair<string, string>("password", "Test123")
            });

            var request = new HttpRequestMessage(HttpMethod.Delete, urlEndpoint)
            {
                Content = content
            };

            var response = await _client.SendAsync(request);

            var responseBody =  response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody.Result);
        }
    }
}