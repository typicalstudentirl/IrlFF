using IrlFF.Data.Models;

namespace IrlFF.Data.Services
{
    public interface IUserService
    {
        // User management
        void Initialize();

        int RegisterUser(User u);

        User GetUserById(int id);

        User Authenticate(string userName, string password);

        User[] GetUsers();
    }
}
