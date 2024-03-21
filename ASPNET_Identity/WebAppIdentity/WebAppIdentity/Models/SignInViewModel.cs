using System.ComponentModel.DataAnnotations;

namespace WebAppIdentity.Models;

public class SignInViewModel
{
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "An email address is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "********")]
    [Required(ErrorMessage = "A password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }

}
