using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Concept { get; set; }
        [Required]
        [Range(0 , double.MaxValue, ErrorMessage = "Negative prices are not allowed")]
        public float Price { get; set; }
        [Required]
        public Currency Unit { get; set; }

        public Person Client{ get; set; }
    }
}
