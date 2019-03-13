using IrlFF.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Services
{
    public interface IUserService
    {
        // User management
        User RegisterUser(User u);

        User GetUserById(int id);

        User Authenticate(string userName, string password);
    }
}
