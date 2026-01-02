
using WebAPI_Project.Models;

namespace WebAPI_Project.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
    }
}
