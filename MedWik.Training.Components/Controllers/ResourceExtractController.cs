using MedWik.Training.Components.Controllers.Helpers;
using MedWik.Training.Components.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MedWik.Training.Components.Controllers
{
    public class ResourceExtractController : ApiController
    {
        //public async Task<IHttpActionResult> ExtractFromWebsite(string urlString)
        public async Task<ResourceEntity> ExtractFromWebsite(string urlString)
        {
            //PageMeta Api : "https://api.pagemeta.io/v1/"

            string apiURL = "https://api.pagemeta.io/";
            string apiPath = "v1/?page="+urlString;
            ResourceEntity resource = await ApiClient.GetApi(apiURL,apiPath).ConfigureAwait(false);
            if (resource == null)
            {
                return null;
            }
            return resource;
        }

        //public IHttpActionResult ExtractFromMedia(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
        //public IHttpActionResult ExtractFromImage(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
    }
}
