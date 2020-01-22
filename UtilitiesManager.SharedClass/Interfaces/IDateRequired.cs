using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManager.SharedCode.Interfaces
{
    interface IDateRequired
    {
        DateTime CreationDate { get; set; }
        DateTime ModificationDate { get; set; }
    }
}
