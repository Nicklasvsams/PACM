namespace PACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.Name = "Sunflowers";
                product.Description = "Assorted size set of 4 bright yellow mini sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call insert procedure
                    }
                    else
                    {
                        // Call update procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
