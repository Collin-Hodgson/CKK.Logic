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
            if (Product1 != null && Product1.GetProduct().GetId() == prod.GetId())
            {
                if (quantity < 1)
                {
                    return null;
                }

                Product1.SetQuantity(Product1.GetQuantity() - quantity);
                return Product1;
            }
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
            decimal total1 = Product1.GetProduct().GetPrice() * Product1.GetQuantity();
            decimal total2 = Product2.GetProduct().GetPrice() * Product2.GetQuantity();
            decimal total3 = Product3.GetProduct().GetPrice() * Product3.GetQuantity();

            return total1 + total2 + total3;
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