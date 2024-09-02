using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch4.MiddlewareApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel requestModel)
        {
            HttpContext.Session.SetString("name",requestModel.UserName);
            return Redirect("/Home");
        }
    }

    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
