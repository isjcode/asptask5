using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace P225Allup.Areas.Manage.Controllers
{
    public class LoginController : Controller
    {
        [Area("manage")]
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
    }
}
