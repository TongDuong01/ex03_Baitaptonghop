using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex03_Baitaptonghop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        public string Image { get; set; } = string.Empty;

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public ProductStatus Status { get; set; } = ProductStatus.Active;

        public int Category_id { get; set; }

        [ForeignKey("Category_id")]
        public Category Category { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}