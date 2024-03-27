using Infrastructure.Enitities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppIdentity.Models;

namespace WebAppIdentity.Controllers
{
    [Authorize]
    public class AccountController(UserManager<UserEntity> userManager) : Controller
    {
        private readonly UserManager<UserEntity> _userManager = userManager;

        #region Details
        [Route("Account/Details")]
        public async Task<IActionResult> Details()
        {
            
            var user = await _userManager.GetUserAsync(User);
            if ( user != null)
            {
                var viewModel = new UpdateUserViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Phone = user.PhoneNumber
                };
                return View(viewModel);
            }
            

            return View();
        }

        [HttpPost]
        [Route("Account/Details")]
        public async Task<IActionResult> Details(UpdateUserViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    user.FirstName = viewModel.FirstName;
                    user.LastName = viewModel.LastName;
                    user.Email = viewModel.Email;
                    user.PhoneNumber = viewModel.Phone;


                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return View(viewModel);
                    }
                    else
                    {
                        ViewData["StatusMessage"] = "Something went wrong. Please try again.";
                    }
                }
                
                
            }
            return View(viewModel);
        }
        #endregion

        #region Security
        [Route("Account/Security")]
        public IActionResult Security()
        {
            return View();
        }
        #endregion

        #region SavedCourses
        [Route("Account/SavedCourses")]
        public IActionResult SavedCourses()
        {
            return View();
        }
        #endregion
    }
}
