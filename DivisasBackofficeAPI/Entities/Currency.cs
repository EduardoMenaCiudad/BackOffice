using System.ComponentModel.DataAnnotations;

namespace DivisasBackofficeAPI.Entities
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(5,  ErrorMessage = "Currency name can't be shorter than 5 characters")]
        [MaxLength(50, ErrorMessage = "Currency name can't be longer than 50 characters")]
        public string Title { get; set; }
        [Required]
        public char Simbol { get; set; }
        [MaxLength(1024, ErrorMessage = "Icon size can't be bigger than 1 MB")]
        public byte[] Icon { get; set; }
    }
}
