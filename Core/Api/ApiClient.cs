using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace playwrightExample.Core.Api
{
   public class ApiClient
    {
        private readonly HttpClient _client;

        public ApiClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://automationexercise.com/api/")
            };
        }

        public async Task<HttpResponseMessage> Get(string endpoint)
        {
            return await _client.GetAsync(endpoint);
        }
 
        public async Task<HttpResponseMessage> Post<T>(string endpoint, T body)
        {
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _client.PostAsync(endpoint, content);
        }
    }
}