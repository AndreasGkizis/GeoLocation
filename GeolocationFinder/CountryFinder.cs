using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GeolocationFinder
{
    public class CountryFinder
    {
        private readonly IClientFactory _httpClientFactory;
        private readonly StringBuilder _sb;
        public CountryFinder(IClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _sb = new StringBuilder();
        }

        public async Task MakeHttpCallAsync(string ip)
        {
            HttpClient client = _httpClientFactory.CreateHTTPClient();

            HttpResponseMessage response = await client.GetAsync(ip);
            await CustomPrint(response);

        }

        public async Task MakeHttpsCallAsync(string ip)
        {
            HttpClient client = _httpClientFactory.CreateHTTPSClient();

            HttpResponseMessage response = await client.GetAsync(ip);
            await CustomPrint(response);

            //await Console.Out.WriteLineAsync(_sb.ToString());
        }


        public async Task MakeHttpCallAsyncWithDecimal(string ip)
        {
            HttpClient client = _httpClientFactory.CreateHTTPClient();

            HttpResponseMessage response = await client.GetAsync(IPToDecimal(ip));
            await CustomPrint(response);

        }

        public async Task MakeHttpsCallAsyncWithDecimal(string ip)
        {
            HttpClient client = _httpClientFactory.CreateHTTPSClient();
            HttpResponseMessage response = await client.GetAsync(IPToDecimal(ip));
            await CustomPrint(response);
        }

        private string IPToDecimal(string ip)
        {
            var parts = ip.Split('.');
            decimal result = 0m;

            for (int i = 0; i < parts.Length; i++)
            {
                result += decimal.Parse(parts[i]) * ((decimal)Math.Pow(256, parts.Length - 1 - i));
            }

            return $"?dec={result}";
        }

        private async Task CustomPrint(HttpResponseMessage response)
        {
            _sb.Clear();
            _sb.Append("Result of the Call is : ");
            _sb.Append(response.StatusCode.ToString());
            _sb.AppendLine();
            _sb.Append("And the servers response is : ");
            _sb.Append(await response.Content.ReadAsStringAsync());

            await Console.Out.WriteLineAsync(_sb.ToString());
        }
    }
}
