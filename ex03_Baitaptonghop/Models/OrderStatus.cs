using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public enum OrderStatus
    {
        [Display(Name = "Chờ xử lý")]
        Pending = 0,

        [Display(Name = "Đã xác nhận")]
        Confirmed = 1,

        [Display(Name = "Đang giao")]
        Shipping = 2,

        [Display(Name = "Hoàn thành")]
        Completed = 3,

        [Display(Name = "Đã hủy")]
        Cancelled = 4
    }
}