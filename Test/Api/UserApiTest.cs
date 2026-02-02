using NUnit.Framework;
using playwrightExample.Core.Api;
using playwrightExample.Core.Utils;
using System.Text.Json;

namespace playwrightExample.Test.API
{
    [TestFixture]
    public class UsersApiTests : BaseApi
    {
        [Test]
        public async Task GetUsers_Returns200()
        {
            var response = await ApiClient.Get("/productsList");
            var body = await response.Content.ReadAsStringAsync();
            //string json = XmlToJsonConverter.ConvertXmlToJson(body);
            //Console.WriteLine(json);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }
    }
}
