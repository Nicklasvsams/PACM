using PACM.Common;

namespace PACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            Id = productId;
        }

        public int Id { get; private set; }
        private string _name { get; set; }
        public string Name 
        {
            get 
            {
                return _name.InsertSpaces();
            }
            set { _name = value; } 
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(Name) || CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => Name;

        public string Log() => "ID: " + Id + " Description: " + Description + " Status: " + EntityState.ToString();
    }
}
