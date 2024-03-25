using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace WebAppIdentity.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        [Route("Account/Details")]
        public IActionResult Details()
        {
            return View();
        }

        [Route("Account/Security")]
        public IActionResult Security()
        {
            return View();
        }

        [Route("Account/SavedCourses")]
        public IActionResult SavedCourses()
        {
            return View();
        }
    }
}
