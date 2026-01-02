using WebAPI_Project.Models;

namespace WebAPI_Project.Services
{
    public interface ILoginService
    {
        bool RegisterUser(User user);
        bool Validate(string? username, string? password);
    }
}
