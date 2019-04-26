using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class UserServiceTest
    {
        private readonly IUserService svc;

        public UserServiceTest()
        {
            svc = new UserService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void UserService_RegisterUser_GetUserById_Success()
        {
            User u = new User { ForeName = "Test", SurName = "Test", Password = "Test", Role = Role.User, UserName = "TestTest" };
            u.Id = svc.RegisterUser(u);

            User newUser = svc.GetUserById(u.Id);

            Assert.Equal(u, newUser);
        }

        [Fact]
        public void UserService_RegisterUser_GetUsers_Success()
        {
            User u = new User { ForeName = "Test", SurName = "Test", Password = "Test", Role = Role.User, UserName = "TestTest" };
            u.Id = svc.RegisterUser(u);

            User[] newUsers = svc.GetUsers();

            Assert.Contains(u, newUsers);
        }
    }
}
