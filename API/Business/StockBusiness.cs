using Shop.API.Models;
using Shop.API.Repository;
namespace Shop.API.Business
{
    public class StockBusiness : IProductBusiness
    {

        private readonly IProductRepository _productRepository;
        public StockBusiness(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }

        public async Task<Product> CreateProduct(Product product)
        {

            if (product.Id > 0)
            {
                throw new Exception("Product exists");
            }
            var result = await _productRepository.CreateProduct(product);
            return result;

        }

        public async Task<Product> DeleteById(int id)
        {
            return await _productRepository.DeleteById(id);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateProduct(product);
        }


        public async Task<bool?> Create(Product product)
        {
            throw new NotImplementedException();
        }
    }
}