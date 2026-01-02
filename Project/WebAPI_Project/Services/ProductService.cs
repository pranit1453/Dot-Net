using WebAPI_Project.DAL;
using WebAPI_Project.Models;

namespace WebAPI_Project.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            return _repo.GetAllProductsAsync();
        }
    }
}
