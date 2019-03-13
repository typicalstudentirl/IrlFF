using System.Collections.Generic;
using System.Linq;
using IrlFF.Data.Models;
using IrlFF.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace IrlFF.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixtureController : ControllerBase
    {
        private IFixtureService _service;

        public FixtureController(IFixtureService service)
        {
            _service = service;
        }

        // GET: api/Fixture
        [HttpGet(Name = "GetFixtures")]
        public ActionResult<IList<Fixture>> Get()
        {
            IList<Fixture> fixtures = _service.GetFixtures();
            return fixtures.ToList<Fixture>();
        }
    }
}