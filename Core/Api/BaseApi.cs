using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace playwrightExample.Core.Api
{
    public class BaseApi
    {
        protected ApiClient ApiClient;

        [SetUp]
        public void Setup()
        {
            ApiClient = new ApiClient();
    
        }
    }
}