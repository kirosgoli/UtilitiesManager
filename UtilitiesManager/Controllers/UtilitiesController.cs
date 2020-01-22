using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UtilitiesManager.Server.Context;

namespace UtilitiesManager.Server.Controllers
{
    public class UtilitiesController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            using (var db = new DatabaseContext())
            {
                return Json(db.Utilities.ToList());
            }
        }



    }
}