using Microsoft.AspNetCore.Mvc;

namespace devOpsPuc.Controllers
{
    [ApiController]
    [Route("DevOpsPuc")]

    public class DevOpsPucController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
