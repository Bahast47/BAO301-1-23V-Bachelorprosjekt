using Microsoft.AspNetCore.Mvc;

namespace Relatude.MVC.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
