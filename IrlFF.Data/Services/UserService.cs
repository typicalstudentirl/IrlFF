using System.Linq;
using IrlFF.Data.Models;
using IrlFF.Data.Repositories;

namespace IrlFF.Data.Services
{
    public class UserService : IUserService
    {

        private readonly FFDbContext ctx;

        public UserService()
        {
            ctx = new FFDbContext();
        }

        /// <summary>
        /// Used to initialise the database - use with care
        /// </summary>
        public void Initialise()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        // User management
        public User GetUserById(int id)
        {
            return ctx.User.FirstOrDefault(u => u.Id == id);
        }

        public User Authenticate(string userName, string password)
        {
            // retrieve the user based on the UserName (assumes Username is unique)
            var user = ctx.User.FirstOrDefault(
                u => u.UserName == userName && BCrypt.Net.BCrypt.Verify(password, u.Password)
            );

            // user not authenticated
            if (user == null)
            {
                return null;
            }

            return user;
        }

        public User RegisterUser(User u)
        {
            // hash the user password
            u.Password = BCrypt.Net.BCrypt.HashPassword(u.Password);
            ctx.User.Add(u);
            ctx.SaveChanges();
            return u;
        }
    }
}
