using Microsoft.AspNetCore.Mvc;
using MongoDBCRUD.Data;
using MongoDBCRUD.Models;

namespace MongoDbBackend.Controllers
{
    public class PeopleController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public PeopleController(MongoDbContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Home()
        {
            
            return Ok("This is Home Route");
        }
        [HttpPost("/")]
        public async Task<IActionResult> CreatePerson([FromBody] Person person)
        {
            Console.WriteLine("hello");
            if (person == null || string.IsNullOrEmpty(person.Name))
            {
                return BadRequest("Name is required.");
            }

            await _context.People.InsertOneAsync(person);
            return Ok("Person created..."); // CreatedAtAction(nameof(CreatePerson), new { id = person.Id }, person);
        }
        [HttpPost("*")]
        public async Task<IActionResult> all([FromBody] Person person)
        {
            return Ok("Not match any route..."); // CreatedAtAction(nameof(CreatePerson), new { id = person.Id }, person);
        }
    }
}