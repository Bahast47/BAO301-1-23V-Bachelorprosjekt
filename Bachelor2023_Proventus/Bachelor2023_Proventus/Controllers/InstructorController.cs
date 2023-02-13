using Microsoft.AspNetCore.Mvc;

namespace Relatude.MVC.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
