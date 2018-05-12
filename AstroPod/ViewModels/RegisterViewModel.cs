using System;
using System.ComponentModel.DataAnnotations;


namespace AstroPod.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "User Role")]
        public string UserRoleId { get; set; }

        [Required]
        [Display(Name = "BirthDate")]
        public string BirthDate { get; set; }

    }
}