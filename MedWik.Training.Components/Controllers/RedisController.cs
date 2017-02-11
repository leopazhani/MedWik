using MedWik.Training.Components.Model;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MedWik.Training.Components.Controllers
{
    public class RedisController : ApiController
    {
        RedisConnection obj = new RedisConnection();
        public string GetDatetime()
        {
            string datetime = "";
            //Creating Redis database instance  
            IDatabase db = obj.Connection.GetDatabase();

            //Getting value of "datetime" key  
            datetime = db.StringGet("datetime");

            //If key not found in Redis database  
            if (datetime == null)
            {
                datetime = Convert.ToString(DateTime.Now);

                //Setting value for key with Expiry time of 5 Minutes  
                db.StringSet("datetime", datetime, TimeSpan.FromMinutes(5));
            }
            return datetime;
        }
    }
}
