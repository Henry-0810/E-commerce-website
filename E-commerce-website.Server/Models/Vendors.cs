using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Server.Models
{
    public class Vendors
    {
        [Key]
        public int VendorId { get; set; }
        public required string VendorName { get; set; }
        public string? VendorAddress { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public required Users Users { get; set; }
    }
}


