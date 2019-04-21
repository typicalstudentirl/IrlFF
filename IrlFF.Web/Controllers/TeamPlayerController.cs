using System.Collections.Generic;
using System.Linq;
using IrlFF.Data.Models;
using IrlFF.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IrlFF.Web.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamPlayerController : ControllerBase
    {
        private ITeamPlayerService _service;

        public TeamPlayerController(ITeamPlayerService service)
        {
            _service = service;
        }

        // GET: api/TeamPlayer/5
        [HttpGet("{id}", Name = "GetPlayersByTeamId")]
        public ActionResult<IList<TeamPlayer>> Get(int id)
        {
            IList<Player> teamPlayer = _service.GetPlayersByTeamId(id);
            if (teamPlayer == null)
            {
                return NotFound();
            }
            return Ok(teamPlayer);
        }

        // DELETE: api/TeamPlayer/
        public ActionResult<bool> Delete(TeamPlayer teamPlayer)
        {
            if (teamPlayer == null)
            {
                return NotFound();
            }
            return _service.DeleteTeamPlayer(teamPlayer);
        }
    }
}
