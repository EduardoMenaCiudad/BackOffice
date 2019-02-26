using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name length minimum is 3 characters")]
        [MaxLength(50, ErrorMessage = "Name length maximum is 50 characters")]
        public string Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Surname length minimum is 2 characters")]
        [MaxLength(50, ErrorMessage = "Surname length maximum is 50 characters")]
        public string Surname { get; set; }
        [MaxLength(11, ErrorMessage = "Phone maximum length = 11 digits")]
        public string Phone { get; set; }
    }
}
