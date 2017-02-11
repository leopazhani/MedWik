using MedWik.Training.Components.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MedWik.Training.Components.Controllers.Helpers
{
    public static class ApiClient
    {
        public static async Task<ResourceEntity> GetApi(string url,string apiPath)
        {
            ResourceEntity resourceEntity= new ResourceEntity();
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:9000/");
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api_key", "1244b1e930954f67c3ebc7cf27013c67");

                // New code:
                HttpResponseMessage response = await client.GetAsync(apiPath).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //resourceEntity = await response.Content.ReadAsAsync<ResourceEntity>();
                }
            }
            return resourceEntity;
        }
    }
}