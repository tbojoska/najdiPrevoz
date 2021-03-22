using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace najdiPrevoz.Models
{
    public class Korisnik
    {
        [Key]
        public int UserId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }


        [Required]
        [Display(Name = "User name")]
        public string Nick { get; set; }

        [Required]
        [Range(12, 100)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Phone number (format 070-000-000)")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Upload user photo")]
        public byte[] UserPhoto { get; set; }


    }
}