using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex03_Baitaptonghop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string CustomerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Địa chỉ giao hàng không được để trống")]
        public string Address { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Ghi chú không được để trống")]
        public string Note { get; set; } = string.Empty;

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public int Account_id { get; set; }

        [ForeignKey("Account_id")]
        public Account Account { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}