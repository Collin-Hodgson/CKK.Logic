namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer Customer;
        private ShoppingCartItem Product1;
        private ShoppingCartItem Product2;
        private ShoppingCartItem Product3;

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
        }

        public int GetCustomerId()
        {
            return Customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (Product1.GetProduct().GetId() == id)
            {
                return Product1;
            }    
            else if (Product2.GetProduct().GetId() == id)
            {
                return Product2;
            }
            else if (Product3.GetProduct().GetId() == id)
            {
                return Product3;
            }
            return null;
        }

        public decimal GetTotal()
        {
        }

        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum == 1)
            {
                return Product1;
            }
            else if (productNum == 2)
            {
                return Product2;
            }
            else if (productNum == 3)
            {
                return Product3;
            }
            return null;
        }
    }
}