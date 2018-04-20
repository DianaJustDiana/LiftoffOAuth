using Microsoft.AspNetCore.Mvc;

namespace LiftoffOAuth.Controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        [HttpGet(""), ActionName("Index")]
        public IActionResult GetIndex()
        {
            return View();
        }
    }
}
