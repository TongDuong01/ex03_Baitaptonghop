using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public enum CategoryStatus
    {
        [Display(Name = "Ẩn danh mục")]
        Hidden = 0,

        [Display(Name = "Hiển thị")]
        Active = 1
    }
}