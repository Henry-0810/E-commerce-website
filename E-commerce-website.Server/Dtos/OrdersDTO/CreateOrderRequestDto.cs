using E_commerce_website.Server.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Server.Dtos.OrdersDTO
{
    public class CreateOrderRequestDto
    {
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public required string OrderStatus { get; set; }
        public required int UserId { get; set; }
        [ForeignKey("UserId")]
        public required Users Users { get; set; }
    }
}
