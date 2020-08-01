using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Publication Year")]
        [Range(1900, 2020)]
        [Required]
        public int FirstPublicationYear { get; set; }

        [Display(Name = "Price")]
        [Range(0, double.PositiveInfinity)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Number of Publications")]
        [Range(0, double.PositiveInfinity)]
        [Required]
        public uint NoOfPublications { get; set; }
    }
}
