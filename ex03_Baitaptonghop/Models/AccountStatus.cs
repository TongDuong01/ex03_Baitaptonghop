using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public enum AccountStatus
    {
        [Display(Name = "Bị khóa")]
        Locked = 0,

        [Display(Name = "Hoạt động")]
        Active = 1,

        [Display(Name = "Chờ kích hoạt")]
        Pending = 2
    }
}