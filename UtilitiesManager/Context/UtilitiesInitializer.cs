using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UtilitiesManager.SharedCode.Models;

namespace UtilitiesManager.Server.Context
{
    public class UtilitiesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var utilities = new List<Utility>
            {
                new Utility{CalculationMode = SharedCode.Models.Enums.CalculationMode.Basic, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = "Prąd", Unit = "kWh" },
                new Utility{CalculationMode = SharedCode.Models.Enums.CalculationMode.Basic, CreationDate = DateTime.Now, ModificationDate = DateTime.Now, Name = "Woda", Unit = "m3" }
            };
            utilities.ForEach(u => context.Utilities.Add(u));
            context.SaveChanges();
        }
    }
}