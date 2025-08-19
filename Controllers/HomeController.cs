using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IDatabase _database;

        public HomeController(IDatabase database)
        {
            _database = database;
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_database.GetItem());
        }

        [HttpPost]
        public IActionResult Add([FromBody] string item)
        {
            _database.AddItem(item);
            return Ok();
        }
    }
}
