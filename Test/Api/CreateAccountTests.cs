using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using playwrightExample.Core.Api;

namespace playwrightExample.Test.Api
{
    [TestFixture]

    public class CreateAccountTests : BaseApi
    {

        [Test]
        public async Task CreateAccount()
        {

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
            var request = await ApiClient.PostForm("/api/createAccount", body);

            var response = request.Content.ReadAsStringAsync();
            Console.WriteLine((int)request.StatusCode);
            Console.WriteLine(response.Result);
            Assert.That((int)request.StatusCode, Is.EqualTo(200));
            Assert.That(response.Result, Does.Contain("User created"));

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