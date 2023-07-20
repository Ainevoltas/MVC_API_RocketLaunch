using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketLaunch.Models;
using System.Net.Sockets;

namespace RocketLaunch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RocketAPIController : ControllerBase
    {

        private static List<RocketModel> rocketData = new List<RocketModel>
        {
            new RocketModel { Id = 1, Name = "Falcon 9", Type = "Reusable" },
            new RocketModel { Id = 2, Name = "Saturn V", Type = "Non-Reusable" },
            new RocketModel { Id = 3, Name = "Atlas V", Type = "Reusable" },
            new RocketModel { Id = 4, Name = "Delta IV", Type = "Non-Reusable" },
            new RocketModel { Id = 5, Name = "SpaceX Starship", Type = "Reusable" },
            new RocketModel { Id = 6, Name = "Soyuz", Type = "Non-Reusable" }
        };


        [HttpPost]
        [Produces("application/json")]
        public IActionResult PostRocket([FromBody] RocketModel rocket)
        {
            if (rocket == null)
            {
                return BadRequest("Rocket data is null.");
            }

            // Display the information received in the model in the console
            Console.WriteLine($"Received Rocket Information:");
            Console.WriteLine($"ID: {rocket.Id}");
            Console.WriteLine($"Name: {rocket.Name}");
            Console.WriteLine($"Type: {rocket.Type}");

            return Ok(rocket);
        }

        [HttpGet("{id}")]
        public IActionResult GetRocket(int id)
        {
            var rocket = rocketData.FirstOrDefault(r => r.Id == id);

            if (rocket == null)
            {
                return NotFound();
            }

            return Ok(rocket);
        }
    }
}
