namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer Customer;
        private ShoppingCartItem Product1;
        private ShoppingCartItem product2;
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
            
        }

        public decimal GetTotal()
        {

        }

        public ShoppingCartItem GetProduct(int productNum)
        {

        }
    }
}
