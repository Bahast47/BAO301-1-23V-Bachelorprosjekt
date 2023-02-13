using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.MySite;
using WAF.Engine.Content.Native;

namespace App.Server.Controllers
{
    public class InstructorController : Controller
    {
        WAFNativeContext _ctx;
        public InstructorController(WAFNativeContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var c = _ctx.Request.GetContent<Instructor>();
            return View(c);
        }
    }
}