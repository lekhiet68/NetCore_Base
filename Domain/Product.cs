using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_MVC_EFB4.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]  
        public string Name { get; set; }
        [Column(TypeName ="decimal(18,4)")]
        public decimal Price { get; set; }
        public string? Desrciption { get; set; }
    }
}
