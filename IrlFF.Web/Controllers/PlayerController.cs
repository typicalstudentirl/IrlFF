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
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private IPlayerService _service;

        public PlayerController(IPlayerService service)
        {
            _service = service;
        }

        // GET: api/Player
        [HttpGet(Name = "GetPlayers")]
        public ActionResult<IList<Player>> Get()
        {
            IList<Player> players = _service.GetPlayers();
            return players.ToList<Player>();
        }

        // GET: api/Player/5
        [HttpGet("{id}", Name = "GetPlayerById")]
        public ActionResult<Player> Get(int id)
        {
            Player player = _service.GetPlayerById(id);
            if (player == null)
            {
                return NotFound();
            }
            return player;
        }

        // POST: api/Player
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public void Post([FromBody] Player player)
        {
            _service.AddPlayer(player);
        }

        // PUT: api/Player/5
        [Authorize]
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Player player)
        {
            if (_service.UpdatePlayer(player) == false)
            {
                return NotFound();
            }
            else return Ok();
        }

        // DELETE: api/Player/5
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.DeletePlayer(id);
        }
    }
}