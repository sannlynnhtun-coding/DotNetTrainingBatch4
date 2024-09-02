using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch4.MiddlewareApp.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
}
