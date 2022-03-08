namespace PACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            Id = orderItemId;
        }

        public int Id { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        
        private bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0 || Id <= 0 || PurchasePrice == null) isValid = false;

            return isValid;
        }

        private OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        private bool Save()
        {
            return true;
        }
    }
}
