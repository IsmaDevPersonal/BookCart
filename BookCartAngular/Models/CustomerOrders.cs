using System;
namespace BookCartAngular.Models
{
    public class CustomerOrders
    {
        public string OrderId { get; set; }

        public int UserId { get; set; }

        public DateTime DateCreated { get; set; }

        public decimal CartTotal { get; set; }
    }
}
