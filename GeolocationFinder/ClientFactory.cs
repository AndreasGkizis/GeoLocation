using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeolocationFinder
{
    public class ClientFactory : IClientFactory
    {
        public HttpClient CreateHTTPClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://ip2c.org/");
            return client;
        }

        public HttpClient CreateHTTPSClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://ip2c.org/");
            return client;
        }
    }
}
