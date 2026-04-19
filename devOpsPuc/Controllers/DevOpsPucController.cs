using Microsoft.AspNetCore.Mvc;

namespace devOpsPuc.Controllers
{
    [ApiController]
    [Route("DevOpsPuc")]
    public class DevOpsPucController : Controller
    {
        private static List<string> games = new List<string>
        {
            "Game 1",
            "Game 2"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(games);
        }

        [HttpPost]
        public IActionResult AddGame([FromBody] string newGame)
        {
            Console.WriteLine($"Novo game recebido: {newGame}");

            games.Add(newGame);

            return Ok(games);
        }
    }
}
