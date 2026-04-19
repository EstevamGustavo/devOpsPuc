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

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= games.Count)
            {
                return Ok(games);
            }

            games.RemoveAt(index);

            return Ok(games);
        }

        [HttpPut("{index}")]
        public IActionResult Update(int index, [FromBody] string updatedGame)
        {
            if (index < 0 || index >= games.Count)
            {
                return Ok(games);
            }

            Console.WriteLine($"Atualizando índice {index} para: {updatedGame}");

            games[index] = updatedGame;

            return Ok(games);
        }

    }
}
