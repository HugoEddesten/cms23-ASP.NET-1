using System.ComponentModel.DataAnnotations;

namespace ASPNET_Assignment.Models
{
    public class SignUpViewModel
    {
        [Display(Name = "First name", Prompt = "Enter your first name")]
        [Required(ErrorMessage = "A first name is required")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last name", Prompt = "Enter your last name")]
        [Required(ErrorMessage = "A last name is required")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Email address", Prompt = "Enter your email address")]
        [Required(ErrorMessage = "An email address is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Email not valid")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Display(Name = "Password", Prompt = "********")]
        [Required(ErrorMessage = "A password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z])(?=.*[*.!@#$%^&(){}[]).{8,}$", ErrorMessage = "Password not valid")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm password", Prompt = "********")]
        [Required(ErrorMessage = "Password Confirmation is reqired")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;


        [Display(Name = "I agree to the Terms & Conditions.")]
        [DeniedValues(values: false, ErrorMessage = "Accepting the Terms and Conditions is required")]
        public bool TermsAndConditions { get; set; }
    }
}
