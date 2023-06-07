using Microsoft.AspNetCore.Mvc;

namespace Server.Presentation.API.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
