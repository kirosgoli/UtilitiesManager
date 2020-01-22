using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;

namespace UtilitiesManager.Tests.Controllers
{
    [TestClass]
    public class UtilitiesControlerTests
    {
        [TestMethod]
        public void Get()
        {
            UtilitiesManager.Server.Controllers.UtilitiesController controller = new Server.Controllers.UtilitiesController();

            IHttpActionResult actionResult = controller.Get();
            JsonResult<List<UtilitiesManager.SharedCode.Models.Utility>> contentResult = actionResult as JsonResult<List<UtilitiesManager.SharedCode.Models.Utility>>;


            

            Assert.IsTrue(true);
        }
    }
}
