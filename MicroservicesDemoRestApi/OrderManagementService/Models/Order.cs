using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EC_Order_Service.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }
        public List<OrderItem>? Items { get; set; }
    }
}
