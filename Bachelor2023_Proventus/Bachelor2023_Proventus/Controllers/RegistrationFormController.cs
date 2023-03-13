using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.MySite;

namespace App.Server.Controllers
{
    public class RegistrationFormController : Controller
    {
        WAFNativeContext _ctx;
        public RegistrationFormController(WAFNativeContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var c = _ctx.Request.GetContent<RegistrationForms>();
            return View(c);
        }
    }
}