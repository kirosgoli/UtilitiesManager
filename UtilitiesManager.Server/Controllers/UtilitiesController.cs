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
        public IHttpActionResult Get()
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    return Json(db.Utilities.ToList());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return null;
        }
    }
}
