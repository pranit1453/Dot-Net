
using Microsoft.EntityFrameworkCore;
using WebAPI_Project.Models;

namespace WebAPI_Project.DAL
{
    public class ProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }   

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.products.ToListAsync();

        }
    }
}
