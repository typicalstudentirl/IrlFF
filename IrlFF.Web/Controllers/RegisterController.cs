using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using IrlFF.Data.Services;
using IrlFF.Web.Helpers;

namespace IrlFf.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUserService _svc;

        public RegisterController(IUserService service, IOptions<AppSettings> appSettings)
        {
            _svc = service;
        }

        //POST api/register
        [HttpPost (Name = "Register")]
        public ActionResult<int> Post([FromBody] [Bind("userName, password")]  User user)
        {
            user.Role = Role.User;
            var u = _svc.RegisterUser(user);
            if (u == 0)
            {
                return BadRequest();
            }
            return u;
        }

    }
}
