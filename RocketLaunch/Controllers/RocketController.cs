using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketLaunch.Models;
using System.Net.Sockets;

namespace RocketLaunch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RocketController : ControllerBase
    {
        [HttpPost]
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
            // Add other properties as needed

            return Ok("Rocket data received successfully.");
        }
    }
}
