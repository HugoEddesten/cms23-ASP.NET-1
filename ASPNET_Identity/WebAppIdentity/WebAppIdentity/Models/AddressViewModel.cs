using System.ComponentModel.DataAnnotations;

namespace WebAppIdentity.Models;

public class AddressViewModel
{
    [Display(Name = "Addess line 1", Prompt = "Enter your address line")]
    [Required(ErrorMessage = "An address line is required")]
    public string Addressline1 { get; set; } = null!;

    [Display(Name = "Addess line 2", Prompt = "Enter your second address line")]
    public string? Addressline2 { get; set; }

    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [Required(ErrorMessage = "A postal code is required")]
    public string PostalCode { get; set; } = null!;

    [Required(ErrorMessage = "A city name is required")]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
}
