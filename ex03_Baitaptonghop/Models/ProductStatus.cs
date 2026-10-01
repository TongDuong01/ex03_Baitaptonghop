using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public enum ProductStatus
    {
        [Display(Name = "Bản nháp")]
        Draft = 0,

        [Display(Name = "Đang bán")]
        Active = 1,

        [Display(Name = "Hết hàng")]
        OutOfStock = 2,

        [Display(Name = "Bị ẩn / Ngừng bán")]
        Suspended = 3
    }
}