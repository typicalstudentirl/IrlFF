using System;
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
            ctx = FFDbContextFactory.CreateCtx();
        }
        public UserService(FFDbContext _ctx)
        {
            ctx = _ctx;
        }

        /// <summary>
        /// Used to initialise the database - use with care
        /// </summary>
        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        // User management
        public User GetUserById(int id)
        {
            return ctx.User.FirstOrDefault(u => u.Id == id);
        }

        public User[] GetUsers()
        {
            User[] users = ctx.User.ToArray<User>();
            foreach (User u in users)
            {
                u.Password = null;
            }
            return users;
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

        public int RegisterUser(User u)
        {
            // hash the user password
            u.Password = BCrypt.Net.BCrypt.HashPassword(u.Password);
            try
            {
                ctx.User.Add(u);
                ctx.SaveChanges();
                return u.Id;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
