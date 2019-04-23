using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        // POST: api/TeamPlayer/
        [HttpPost (Name = "AddTeamPlayer")]
        public ActionResult<TeamPlayer> Post(TeamPlayer teamPlayer)
        {
            if (teamPlayer.PlayerId == 0 || teamPlayer.TeamId == 0)
            {
                return NotFound();
            }
            return _service.AddTeamPlayer(teamPlayer.TeamId, teamPlayer.PlayerId);
        }

        // DELETE: api/TeamPlayer/
        [HttpDelete(Name = "DeleteTeamPlayer")]
        public ActionResult<bool> Delete([FromBody] TeamPlayer teamPlayer)
        {
            if (teamPlayer.PlayerId == 0 || teamPlayer.TeamId == 0)
            {
                return NotFound();
            }
            return _service.DeleteTeamPlayer(teamPlayer.TeamId, teamPlayer.PlayerId);
        }
    }
}
