using System;
namespace BookCartAngular.Models
{
    public class CustomerOrderDetails
    {
       public int OrderDetailsId { get; set; }

        public string OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
