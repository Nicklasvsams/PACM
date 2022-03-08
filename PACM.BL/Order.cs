using PACM.Common;
using System;
using System.Collections.Generic;

namespace PACM.BL
{
    public class Order : EntityBase, ILoggable
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
        
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString() => "Order date: " + OrderDate.Value.Date + " ID: " + Id;

        public string Log() => "ID: " + Id + " Customer ID: " + CustomerId + " Shipping Address ID: " + ShippingAddressId + " Order Date: " + OrderDate.Value.Date + " Status " + EntityState.ToString();
    }
}
