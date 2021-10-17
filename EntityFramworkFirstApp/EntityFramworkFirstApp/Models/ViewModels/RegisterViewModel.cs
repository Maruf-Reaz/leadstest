using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramworkFirstApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter a valid User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter a valid Full Name")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [EmailAddress(ErrorMessage = "Please Insert a valid Email")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Two passwords do not match")]
        public string PasswordConfirm { get; set; }
    }
}
