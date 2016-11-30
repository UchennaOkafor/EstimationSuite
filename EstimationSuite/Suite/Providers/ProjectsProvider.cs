using Suite.Models;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Suite.Providers
{
    public class ProjectsProvider : BaseSuiteProvider
    {
        private HttpClient client;

        public ProjectsProvider()
        {
            client = GetHttpClient();
        }

        public Project[] GetAllProjects()
        {
            return JsonConvert.DeserializeObject<Project[]>(client.GetStringAsync("projects").Result);
        }

        public Project GetProjectById(int id)
        {
            string json = client.GetStringAsync($"projects/{id}").Result;
            return json == "{}" ? null : JsonConvert.DeserializeObject<Project>(json);
        }

        public Project[] GetProjectsByName(string name)
        {
            return JsonConvert.DeserializeObject<Project[]>(client.GetStringAsync($"projects/search/{name}").Result);
        }

        public bool DeleteProject(int projectId)
        {
            return client.DeleteAsync($"projects/{projectId}").Result.IsSuccessStatusCode;
        }

        public bool EditProject(Project project)
        {
            return client.PutAsync($"projects/{project.Id}", CreateProjectPostBody(project)).Result.IsSuccessStatusCode;
        }

        public bool AddProject(Project project)
        {
            return client.PostAsync("projects", CreateProjectPostBody(project)).Result.IsSuccessStatusCode;
        }

        private FormUrlEncodedContent CreateProjectPostBody(Project project)
        {
            return new FormUrlEncodedContent(new Dictionary<string, string>() { { "name", project.Name } });
        }

        public Set[] GetSetsNotIn(int projectId)
        {
            return JsonConvert.DeserializeObject<Set[]>(client.GetStringAsync($"projects/sets/not_in/{projectId}").Result);
        }

        public Part[] GetPartsNotIn(int projectSetId)
        {
            return JsonConvert.DeserializeObject<Part[]>(client.GetStringAsync($"projects/parts/not_in/{projectSetId}").Result);
        }

        public bool CreateProjectSets(int projectId, List<int> setIds)
        {
            var postBody = new Dictionary<string, string>()
            {
                {"project_id" , projectId.ToString()},
                {"set_ids" , JsonConvert.SerializeObject(setIds)},
            };

            return client.PostAsync($"projects/project_set", new FormUrlEncodedContent(postBody)).Result.IsSuccessStatusCode;
        }

        public bool DeleteProjectSet(int projectSetId)
        {
            return client.DeleteAsync($"projects/project_set/{projectSetId}").Result.IsSuccessStatusCode;
        }

        public string GetReportUrl(int projectId)
        {
            return $"{websiteUrl}/reports/project/{projectId}";
        }
    }
}