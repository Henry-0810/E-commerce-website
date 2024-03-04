using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Server.Models
{
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public double UnitPrice { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public required Orders Orders { get; set; }
        [ForeignKey("ProductId")]
        public required Products Products { get; set; }
    }
}
