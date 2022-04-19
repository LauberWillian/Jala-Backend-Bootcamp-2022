using System.Collections.Generic;
using NUnit.Framework;
using Shop.API.Business;
using Shop.API.Models;

namespace Tests
{
    class CrateTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ShouldAddToCrate()
        {
            var item1 = new Product()
            {
                CategoryId = 1,
                Description = null,
                StockId = 1,
                Name = "Bermuda",
                Price = 33.15M,
                Sku = "mmonwa",
                Category = null,
                Stock = null

            };

            var item2 = new Product()
            {
                CategoryId = 1,
                Description = null,
                StockId = 1,
                Name = "Bermuda",
                Price = 33.15M,
                Sku = "mmonwa",
                Category = null,
                Stock = null

            };

            var crate = new Crate()
            {
                Id = 1,
                total = 300,
                products = new List<Product>() { item1, item2 }
            };

            var business = new CreateBusiness();
            var result = business.AddToCart(crate);
            Assert.AreEqual(result, crate);
            Assert.Contains(item1, crate.products);
            Assert.Greater(crate.total, 250);
            // https://docs.nunit.org/articles/nunit/writing-tests/assertions/classic-assertions/Assert.Contains.html
        }


        [Test]
        public void DeleteFromCrate()
        {

        }
    }
}