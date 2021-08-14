using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace coinbase_api_console_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = client.GetAsync(url).Result;

            var responseBody = httpResponseMessage.Content.ReadAsStringAsync().Result;

            var returnedRespose = JsonConvert.DeserializeObject<Response>(responseBody);

            Console.WriteLine("BTC Price: " + returnedRespose.Bpi.EUR.Rate);
        }
        
    }
}
