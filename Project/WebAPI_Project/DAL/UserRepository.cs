using WebAPI_Project.Models;

namespace WebAPI_Project.DAL
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {   
            _context = context;
        }

        public bool Validate(string? username, string? password)
        {
           return _context.users.Any(u=>username==u.Username && password==u.Password);
        }

        public bool RegisterUser(string username, string password, string email)
        {
            var user = new User
            {
                Username = username,
                Password = password,
                Email = email
            };

            _context.users.Add(user);
            _context.SaveChanges();

            return true;
        }
    }
}
