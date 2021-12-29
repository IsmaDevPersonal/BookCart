using System;
namespace BookCartAngular.Models
{
    public class CartItems
    {
        public int CartItemId { get; set; }

        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
