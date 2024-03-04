using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Server.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Category { get; set; }
        public int VendorId { get; set; }
        [ForeignKey("VendorId")]
        public required Vendors Vendors { get; set; }
    }
}
