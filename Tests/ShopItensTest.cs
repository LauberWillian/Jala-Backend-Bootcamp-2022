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
            ShopItem item = new ShopItem(product, 1);
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
            ShopItem item = new ShopItem(product, 1);  
            
            
            Assert.IsTrue(carrinho.getItemCount() > 0);
        }
    }



}