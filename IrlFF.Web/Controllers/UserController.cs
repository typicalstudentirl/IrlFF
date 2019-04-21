using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using IrlFF.Data.Services;
using IrlFF.Web.Helpers;
//using IrlFF.Rest.Helpers;

namespace IrlFf.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        private readonly IUserService _svc;

        public UserController(IUserService service, IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _svc = service;
        }

        // POST api/user
        [HttpPost (Name = "Login")]
        public ActionResult<User> Post([FromBody][Bind("username, password")] User u)
        {
            var user = _svc.Authenticate(u.UserName, u.Password);
            if (user == null)
            {
                return BadRequest();
            }
            return JwtHelper.SignJwtToken(user, _appSettings.Secret);
        }

        [HttpGet (Name = "CheckUniqueUsername" )]
        public ActionResult<User[]> Get(string username = null)
        {
            return _svc.GetUsers();
        }
    }
}
