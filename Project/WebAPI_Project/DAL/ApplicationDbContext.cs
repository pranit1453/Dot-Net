using Microsoft.EntityFrameworkCore;
using WebAPI_Project.Models;

namespace WebAPI_Project.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<User> users {  get; set; }
        public DbSet<Product> products { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
