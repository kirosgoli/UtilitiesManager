using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilitiesManager.SharedCode.Models.Responses
{
    public abstract class Response
    {
        public bool HasError { get; set; }
        public string ErrorDescription { get; set; }

    }
}