using System.ComponentModel.DataAnnotations;

namespace ex03_Baitaptonghop.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vai trò không được để trống")]
        public AccountRole Role { get; set; } = AccountRole.Customer;

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public AccountStatus Status { get; set; } = AccountStatus.Active;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}