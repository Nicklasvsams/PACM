using System;
using System.Collections.Generic;

namespace PACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }

        public Order(int orderId)
        {
            Id = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int Id { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        
        private bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString() => "Order date: " + OrderDate.Value.Date + " ID: " + Id;
    }
}
