using Newtonsoft.Json;
using Suite.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace Suite.Providers
{
    public class SetsProvider : BaseSuiteProvider
    {
        private HttpClient client;

        public SetsProvider()
        {
            client = GetHttpClient();
        }

        public Set[] GetAllSets()
        {
            return JsonConvert.DeserializeObject<Set[]>(client.GetStringAsync("sets").Result);
        }

        public Set GetSetById(int id)
        {
            string json = client.GetStringAsync($"sets/{id}").Result;
            return json == "{}" ? null : JsonConvert.DeserializeObject<Set>(json);
        }

        public Set[] GetSetsByName(string name)
        {
            return JsonConvert.DeserializeObject<Set[]>(client.GetStringAsync($"sets/search/{name}").Result);
        }

        public bool DeleteSet(int setId)
        {
            return client.DeleteAsync($"sets/{setId}").Result.IsSuccessStatusCode;
        }

        public bool EditSet(Set set)
        {
            return client.PutAsync($"sets/{set.Id}", CreateSetPostBody(set)).Result.IsSuccessStatusCode;
        }

        public bool AddSet(Set set)
        {
            return client.PostAsync("sets", CreateSetPostBody(set)).Result.IsSuccessStatusCode;
        }

        private FormUrlEncodedContent CreateSetPostBody(Set set)
        {
            return new FormUrlEncodedContent(new Dictionary<string, string>() { { "name", set.Name } });
        }

        public bool CreateSetParts(int projectSetId, List<int> partIds)
        {
            var postBody = new Dictionary<string, string>()
            {
                {"project_set_id" , projectSetId.ToString()},
                {"part_ids" , JsonConvert.SerializeObject(partIds)},
            };

            return client.PostAsync($"sets/set_part", new FormUrlEncodedContent(postBody)).Result.IsSuccessStatusCode;
        }

        public bool DeleteSetPart(int projectSetId, int partId)
        {
            return client.DeleteAsync($"sets/set_part/{projectSetId}/{partId}").Result.IsSuccessStatusCode;
        }
    }
}
