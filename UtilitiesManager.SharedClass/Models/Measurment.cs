using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManager.SharedCode.Interfaces;

namespace UtilitiesManager.SharedCode.Models
{
    public class Measurment :IDateRequired
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get ; set ; }

        public  Utility Utility { get; set; }
    }
}
