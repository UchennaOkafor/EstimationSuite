using Suite.Models;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Suite.Providers
{
    public class PartsProvider : BaseSuiteProvider
    {
        private HttpClient client;

        public PartsProvider()
        {
            client = GetHttpClient();
        }

        public async Task<Part[]> GetAllParts()
        {
            return JsonConvert.DeserializeObject<Part[]>(await client.GetStringAsync("parts"));
        }

        public async Task<Part> GetPartById(int id)
        {
            string json = await client.GetStringAsync($"parts/{id}");
            return json == "{}" ? null : JsonConvert.DeserializeObject<Part>(json);
        }

        public async Task<Part[]> GetPartsByName(string name)
        {
            return JsonConvert.DeserializeObject<Part[]>(await client.GetStringAsync($"parts/search/{name}"));
        }

        public bool DeletePart(int partId)
        {
            return client.DeleteAsync($"parts/{partId}").Result.IsSuccessStatusCode;
        }

        public bool EditPart(Part part)
        {
            return client.PutAsync($"parts/{part.Id}", CreatePartPostBody(part)).Result.IsSuccessStatusCode;
        }

        public bool AddPart(Part part)
        {
            return client.PostAsync("parts/", CreatePartPostBody(part)).Result.IsSuccessStatusCode;
        }

        private FormUrlEncodedContent CreatePartPostBody(Part part)
        {
            var postBody = new Dictionary<string, string>()
            {
                {"name" , part.Name},
                {"weight" , part.Weight.ToString()},
                {"units" , part.Units.ToString()},
                {"stock" , part.Stock.ToString()},
                {"length" , part.Length.ToString()},
                {"width" , part.Width.ToString()},
                {"sales_price" , part.SalesPrice.ToString()},
                {"purchase_price" , part.PurchasePrice.ToString()}
            };

            return new FormUrlEncodedContent(postBody);
        }
    }
}