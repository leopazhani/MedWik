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

        public async Task<ResourceEntity> ExtractFromWebsite(string urlString)
        {
            //PageMeta Api : "https://api.pagemeta.io/v1/"
           
            ResourceEntity resource = await ApiClient.GetWebSiteResource(urlString).ConfigureAwait(false);
            if (resource == null)
            {
                return null;
            }
            return resource;
        }

        public async Task<IHttpActionResult> ExtractFromMedia(string fileUrl)
        {
            ResourceEntity resource = await ApiClient.GetMediaResource(fileUrl).ConfigureAwait(false);
            if (resource == null)
            {
                return NotFound();
            }
            return Ok(resource);
        }

        public async Task<IHttpActionResult> ExtractFromImage(string imgURL)
        {
            ResourceEntity resource= await ApiClient.GetImageResource(imgURL).ConfigureAwait(false);
            if (resource == null)
            {
                return NotFound();
            }
            return Ok(resource);
        }
    }
}
