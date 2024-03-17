using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Assignment.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
