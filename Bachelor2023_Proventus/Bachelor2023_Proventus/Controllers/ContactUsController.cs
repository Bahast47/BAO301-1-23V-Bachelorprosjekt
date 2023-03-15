using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.MySite;

namespace App.Server.Controllers
{
    public class ContactUsController : Controller
    {
        WAFNativeContext _ctx;
        public ContactUsController(WAFNativeContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var c = _ctx.Request.GetContent<ConatctUs>();
            return View(c);
        }
    }
}