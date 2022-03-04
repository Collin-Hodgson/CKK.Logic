using System;
using CKK.Logic.Models;
using Xunit;

namespace CKK.Test.Models
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddProductSuccessfully()
        {
                // Arrange
                Customer testCustomer = new Customer();
                Product testProduct = new Product();
                ShoppingCart testCart = new ShoppingCart(testCustomer);


                // Act
                testProduct.SetId(1);
                testCustomer.SetId(1);

                int Actual = testCart.AddProduct(testProduct, 2).GetQuantity();

                // Assert
                Assert.Equal(2, Actual);
        }

        [Fact]
        public void RemoveProductSuccessfully()
        {
            // Arrange

            // Act

            // Assert

        }

        [Fact]
        public void GetTotalSuccessfully()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
