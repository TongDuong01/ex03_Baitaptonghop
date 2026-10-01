using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public enum AccountRole
    {
        [Display(Name = "Quản trị viên")]
        Admin = 0,

        [Display(Name = "Khách hàng")]
        Customer = 1,

        //[Display(Name = "Nhân viên")]
        //Staff = 2
    }
}