using Microsoft.AspNetCore.Mvc;

namespace WebAppIdentity.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
