using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public CategoryStatus Status { get; set; } = CategoryStatus.Active;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}