using ASPNET_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Assignment.Controllers
{
    public class AuthController : Controller
    {
        #region SignIn
        [HttpGet]
        [Route("/Signin")]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [Route("/Signin")]
        public IActionResult SignIn(SignInViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        #endregion

        #region SignUp
        [HttpGet]
        [Route("/Signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("/Signup")]
        public IActionResult SignUp(SignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(viewModel);
        }
        #endregion
    }
}
