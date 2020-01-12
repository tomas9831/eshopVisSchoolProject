using DataLibrary.BussinessLogic;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // GET: api/Game
        [HttpGet]
        public Collection<GameModel> Get()
        {
            return GameProcessor.GetAllResults();
        }

        // GET: api/Game/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Game
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Game/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
