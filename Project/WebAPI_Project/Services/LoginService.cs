using WebAPI_Project.DAL;
using WebAPI_Project.Models;

namespace WebAPI_Project.Services
{
    public class LoginService:ILoginService
    {
        private readonly IUserRepository _repo;

        public LoginService(IUserRepository repo)
        {
            _repo = repo;
        }

        public bool Validate(string? username, string? password)
        {
            return _repo.Validate(username, password);
        }

        public bool RegisterUser(User user)
        {
            if (user != null)
            {
                if (user.Username != null && user.Password != null && user.Email != null)
                {
                    return _repo.RegisterUser(user.Username, user.Password, user.Email);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
