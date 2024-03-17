using ASPNET_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Assignment.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(viewModel);
        }
    }
}
