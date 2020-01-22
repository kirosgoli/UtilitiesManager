using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManager.SharedCode.Interfaces;

namespace UtilitiesManager.SharedCode.Models
{
    public class Utility :IDateRequired
    {

        public int Id { get; set; }
        [Key,Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Unit { get; set; }
        [Required]
        public Enums.CalculationMode CalculationMode { get; set; }
        public decimal BasicValue { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime ModificationDate { get; set; }
        public ICollection<Measurment> Measurments { get; set; }
    }
}
