using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManager.Server.Context;
using UtilitiesManager.SharedCode.Models;

namespace UtilitiesManager.Tests.Initialization
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var utilities = new List<Utility>
            {
                new Utility{CalculationMode = SharedCode.Models.Enums.CalculationMode.Basic, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = "Gaz", Unit = "m3" }
            };
            utilities.ForEach(u => context.Utilities.Add(u));
            context.SaveChanges();
        }
    }
}
