using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex03_Baitaptonghop.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 1")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Tổng giá không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng giá không được là số âm")]
        public double Total_price { get; set; }

        //[Required(ErrorMessage = "Mã đơn hàng không được để trống")]
        public int Order_id { get; set; }

        [ForeignKey("Order_id")]
        public Order Order { get; set; } = null!;

        //[Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        public int Product_id { get; set; }

        [ForeignKey("Product_id")]
        public Product Product { get; set; } = null!;
    }
}