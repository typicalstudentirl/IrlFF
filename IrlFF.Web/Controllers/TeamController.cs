using System.Collections.Generic;
using System.Linq;
using IrlFF.Data.Models;
using IrlFF.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IrlFF.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private ITeamService _service;

        public TeamController(ITeamService service)
        {
            _service = service;
        }

        // GET: api/Team
        [HttpGet (Name = "GetTeams")]
        public ActionResult<IList<Team>> Get(string orderby)
        {
            IList<Team> teams = _service.GetTeams(orderby);
            return teams.ToList();
        }

        // GET: api/Team/5
        [HttpGet("{id}", Name = "GetTeamById")]
        public ActionResult<Team> Get(int id)
        {
            Team team = _service.GetTeamById(id);
            if (team == null)
            {
                return NotFound();
            }
            return team;
        }

        // POST: api/Team
        [HttpPost]
        public void Post([FromBody] Team team)
        {
            _service.AddTeam(team);
        }

        // PUT: api/Team/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public void Put(int id, [FromBody] Team team)
        {
                _service.UpdateTeam(team);
        }
    }
}