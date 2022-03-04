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
            Customer testCustomer = new Customer();
            Product testProduct = new Product();
            ShoppingCart testCart = new ShoppingCart(testCustomer);

            // Act
            testProduct.SetId(1);
            testCustomer.SetId(1);

            testCart.AddProduct(testProduct, 5).GetQuantity();
            int ActualRemove = testCart.RemoveProduct(testProduct, 4).GetQuantity();

            // Assert
            Assert.Equal(1, ActualRemove);

        }

        [Fact]
        public void GetTotalSuccessfully()
        {
            // Arrange
            Customer testCustomer = new Customer();
            ShoppingCart testShopping = new ShoppingCart(testCustomer);
            Product testProduct1 = new Product();
            Product testProduct2 = new Product();
            Product testProduct3 = new Product();

            // Act
            testProduct1.SetId(1);
            testProduct2.SetId(2);
            testProduct3.SetId(3);

            testProduct1.SetPrice(1);
            testProduct2.SetPrice(1);
            testProduct3.SetPrice(1);

            testShopping.AddProduct(testProduct1, 2);
            testShopping.AddProduct(testProduct2, 2);
            testShopping.AddProduct(testProduct3, 2);

            decimal Actual = testShopping.GetTotal();

            // Assert
            Assert.Equal(6, Actual);

        }
    }
}
