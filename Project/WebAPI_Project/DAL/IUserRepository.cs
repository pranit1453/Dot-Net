namespace WebAPI_Project.DAL
{
    public interface IUserRepository
    {
        bool RegisterUser(string username, string password, string email);
        bool Validate(string? username, string? password);
    }
}
