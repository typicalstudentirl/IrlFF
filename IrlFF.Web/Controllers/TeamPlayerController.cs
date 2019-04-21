using System.Collections.Generic;
using System.Linq;
using IrlFF.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IrlFF.Web.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamPlayer : ControllerBase
    {
        private ITeamPlayerService _service;

        public TeamPlayer(ITeamPlayerService service)
        {
            _service = service;
        }

        // GET: api/TeamPlayer/5
        [HttpGet("{id}", Name = "GetPlayersByTeamId")]
        public ActionResult<IList<TeamPlayer>> Get(int id)
        {
            var teamPlayer = _service.GetPlayersByTeamId(id);
            if (teamPlayer == null)
            {
                return NotFound();
            }
            return Ok(teamPlayer);
        }
    }
}
