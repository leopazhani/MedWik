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
           
            ResourceEntity resource = await ApiClient.GetApi(urlString).ConfigureAwait(false);
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

        ////public IHttpActionResult ExtractFromMedia(int id)
        ////{
        ////    var product = products.FirstOrDefault((p) => p.Id == id);
        ////    if (product == null)
        ////    {
        ////        return NotFound();
        ////    }
        ////    return Ok(product);
        ////}

        public async Task<IHttpActionResult> ExtractFromImage(string imgURL)
        {
            ResourceEntity resource= await ApiClient.GetApi1(imgURL).ConfigureAwait(false);
            if (resource == null)
            {
                return NotFound();
            }
            return Ok(resource);
        }
    }
}
