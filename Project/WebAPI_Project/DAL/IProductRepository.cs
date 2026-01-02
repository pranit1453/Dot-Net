
using WebAPI_Project.Models;

namespace WebAPI_Project.DAL
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
    }
}
