using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UtilitiesManager.Server.Context
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext() :base("DatabaseConnString")
        {

        }
        public DbSet<UtilitiesManager.SharedCode.Models.Utility> Utilities { get; set; }
        public DbSet<UtilitiesManager.SharedCode.Models.Measurment> Measurments { get; set; }
    }
}