using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IrlFF.Data.Models;
using IrlFF.Data.Services;
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
        [HttpGet]
        public ActionResult<IList<Player>> Get()
        {
            IList<Player> players = _service.GetPlayers();
            return players.ToList<Player>();
        }

        // GET: api/Player/5
        [HttpGet("{id}", Name = "Get")]
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
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] Player player)
        {
                _service.UpdatePlayer(player);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using IrlFF.Data.Models;
//using IrlFF.Data.Repositories;

//namespace IrlFF.Web.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PlayersController : ControllerBase
//    {
//        private readonly FFDbContext _context;

//        public PlayersController(FFDbContext context)
//        {
//            _context = context;
//        }

//        GET: api/Players
//       [HttpGet]
//        public async Task<ActionResult<IEnumerable<Player>>> GetPlayer()
//        {
//            return await _context.Player.ToListAsync();
//        }

//        GET: api/Players/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Player>> GetPlayer(int id)
//        {
//            var player = await _context.Player.FindAsync(id);

//            if (player == null)
//            {
//                return NotFound();
//            }

//            return player;
//        }

//        PUT: api/Players/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutPlayer(int id, Player player)
//        {
//            if (id != player.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(player).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!PlayerExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        POST: api/Players
//       [HttpPost]
//        public async Task<ActionResult<Player>> PostPlayer(Player player)
//        {
//            _context.Player.Add(player);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetPlayer", new { id = player.Id }, player);
//        }

//        DELETE: api/Players/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Player>> DeletePlayer(int id)
//        {
//            var player = await _context.Player.FindAsync(id);
//            if (player == null)
//            {
//                return NotFound();
//            }

//            _context.Player.Remove(player);
//            await _context.SaveChangesAsync();

//            return player;
//        }

//        private bool PlayerExists(int id)
//        {
//            return _context.Player.Any(e => e.Id == id);
//        }
//    }
//}
