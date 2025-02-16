using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web_MVC_EFB4.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage ="Tên sản phẩm không được để trống")]
        public string Name { get; set; }
        [DisplayName("Giá sản phẩm")]
        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public decimal Price { get; set; }
        [DisplayName("Mô tả sản phẩm")]
        public string? Desrciption { get; set; }
    }
}
