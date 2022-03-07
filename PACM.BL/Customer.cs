namespace PACM.BL
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Customer Retrieve()
        {
            return this;
        }

        public void Save()
        {
            
        }
    }
}
