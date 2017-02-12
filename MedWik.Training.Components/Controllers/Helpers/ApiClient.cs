using MedWik.Training.Components.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MedWik.Training.Components.Controllers.Helpers
{
    public static class ApiClient
    {
        public static async Task<ResourceEntity> GetWebSiteResource(string urlString)
        {
            TrainingMetadata metaDataEntity = new TrainingMetadata();
            TrainingData trainingDataEntity = new TrainingData();

            // Getting MetaData
            string apiURL = "https://api.pagemeta.io/v1/?page=" + urlString;
            using (var client = new HttpClient())
            {
               // client.BaseAddress = new Uri(apiURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api_key", "1244b1e930954f67c3ebc7cf27013c67");
                // New code:
                HttpResponseMessage response = await client.GetAsync(apiURL).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    //string responseBody = await response.Content.ReadAsStringAsync();
                    metaDataEntity = await response.Content.ReadAsAsync<TrainingMetadata>();
                }
            }

            //Getting TrainingData
            // Getting MetaData
            string url = "https://mercury.postlight.com/parser?" + urlString;
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-api-key", "X1NXKOcCLnHkfomBUAHU4TsdPXL80qvNmVWoIfoK");
                HttpResponseMessage response = await client.GetAsync(apiURL).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    //string responseBody = await response.Content.ReadAsStringAsync();
                    trainingDataEntity = await response.Content.ReadAsAsync<TrainingData>();
                }
            }
            return EntityHelper.GetResourceEntity(trainingDataEntity, metaDataEntity);
        }

        public static async Task<ResourceEntity> GetImageResource(string urlString)
        {
            ResourceEntity resourceEntity = new ResourceEntity();
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "d97393cf5ddb4ca699d8bccd4fb0af0a");

            // Request parameters
            queryString["maxCandidates"] = "1";
            var uri = "https://westus.api.cognitive.microsoft.com/vision/v1.0/describe?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("{body}");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(urlString, content);
            }

            return resourceEntity;
        }

        public static async Task<ResourceEntity> GetMediaResource(string file)
        {
            ResourceEntity entity = new ResourceEntity();
            return entity;
        }
    }
}