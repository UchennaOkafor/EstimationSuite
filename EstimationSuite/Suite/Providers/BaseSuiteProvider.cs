using System;
using Suite.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Suite.Providers
{
    public class BaseSuiteProvider
    {
        private readonly string apiKey;
        protected readonly string websiteUrl;
        protected readonly string apiUrl;
        private HttpClient client;

        public BaseSuiteProvider()
        {
            websiteUrl = "http://localhost.:8000";
            apiUrl = websiteUrl + $"/api/";
            apiKey = "eHNiLmtYQ0V1Tj9nL2JzQ0RRVklCd1U2Sw==";
            client = GetHttpClient();
        }

        protected HttpClient GetHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("API-Key", apiKey);
            return httpClient;
        }
        
        public async Task<Statistics> GetStatistics()
        {
            return JsonConvert.DeserializeObject<Statistics>(await client.GetStringAsync("stats"));
        }
    }
}