using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.MySite;
using WAF.Engine.Content.Native;

namespace App.Server.Controllers
{
    public class CourseController : Controller
    {
        WAFNativeContext _ctx;
        public CourseController(WAFNativeContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var c = _ctx.Request.GetContent<Course>();
            return View(c);
        }
        public IActionResult List()
        {
            var c = _ctx.Request.GetContent<ArticleBase>();
            return View(c);
        }
    }
}