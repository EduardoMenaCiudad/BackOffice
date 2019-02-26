using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Entities
{
    public class Exchange
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Currency Origin { get; set; }
        [Required]
        public Currency Destiny { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Exchange value can't be negative")]
        public float Value { get; set; }
    }
}
