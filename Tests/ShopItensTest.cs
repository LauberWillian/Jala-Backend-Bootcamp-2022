using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Threading.Tasks;
using NUnit.Framework;
using Shop.API.Business;
using Shop.API.Models;

namespace Tests
{

    public class ShopItensTest
    {

        [SetUp]
        public void SetUp()
        {

        }
        
        [Test]
        public async Task IncrementShoppingCart()
        {
            var product = new Product()
            {
                Name = "Teste",
                Description = "Teste",
                Price = 10,
                Quantity = 10
            };

            var carrinho = new ShoppingCart();
            ShoppingCartItem item = new ShoppingCartItem(product, 1);
            item.IncrementQunatity();
            
            Assert.IsTrue(carrinho.getItemCount() > 0);
        }

        [Test]
        public async Task CreateANewProduct()
        {
            var product = new Product()
            {
                Name = "Teste",
                Description = "Teste",
                Price = 10,
                Quantity = 10
            };

            var carrinho = new ShoppingCart();
            ShoppingCartItem item = new ShoppingCartItem(product, 1);  
            
            
            Assert.IsTrue(carrinho.getItemCount() > 0);
        }
    }

    public class ShoppingCartItem
    {
        private readonly Product product;
        private int quantity = 0;

        public ShoppingCartItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        
        public int IncrementQunatity()
        {
            this.quantity++;
            return quantity;
        }
    }

    public class ShoppingCart
    {
        List<Product> products = new List<Product>();
        public void removeFromStock(ShoppingCartItem item)
        {
            //remove from stock logic
        }
        
        public void getTotalPrice(CurrencyType currency)
        {
            //get total price logic
        }
        public int getItemCount()
        {
            return products.Count;
        }
    }

    public class CurrencyType
    {
    }
}