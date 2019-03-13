using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IrlFF.Data.Models;
using IrlFF.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IrlFF.Web.Controllers
{
    [Authorize (Roles = "Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private IClubService _service;

        public ClubController(IClubService service)
        {
            _service = service;
        }

        // GET: api/Club
        [HttpGet(Name = "GetClubs")]
        public ActionResult<IList<Club>> Get()
        {
            IList<Club> clubs = _service.GetClubs();
            return clubs.ToList<Club>();
        }

        // GET: api/Club/5
        [HttpGet("{id}", Name = "GetClubById")]
        public ActionResult<Club> Get(int id)
        {
            Club club = _service.GetClubById(id);
            if (club == null)
            {
                return NotFound();
            }
            return club;
        }
    }
}