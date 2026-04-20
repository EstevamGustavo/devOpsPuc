using Microsoft.AspNetCore.Mvc;
using devOpsPuc.Services;
using devOpsPuc.DTOs;

namespace devOpsPuc.Controllers
{
    [ApiController]
    [Route("DevOpsPuc")]
    public class DevOpsPucController : ControllerBase
    {
        private readonly IGameService _service;

        public DevOpsPucController(IGameService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{index}")]
        public IActionResult GetByIndex(int index)
        {
            var game = _service.GetByIndex(index);

            if (game == null)
                return NotFound("Índice não encontrado");

            return Ok(game);
        }

        [HttpPost]
        public IActionResult AddGame([FromBody] GameDto dto)
        {
            return Ok(_service.Add(dto));
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            return Ok(_service.Delete(index));
        }

        [HttpPut("{index}")]
        public IActionResult Update(int index, [FromBody] GameDto dto)
        {
            return Ok(_service.Update(index, dto));
        }
    }
}