namespace PACM.BL
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float CurrentPrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Product Retrieve()
        {
            return this;
        }

        public void Save()
        {

        }
    }
}
