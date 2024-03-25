using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppIdentity.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        [Route("/Courses")]
        public IActionResult Courses()
        {
            return View();
        }
    }
}
