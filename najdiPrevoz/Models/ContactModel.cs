using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace najdiPrevoz.Models
{
    public class ContactModel
    {
        [Key]
        public long id { get; set; }
        [Required, Display(Name = "Име")]
        public string SenderName { get; set; }
        [Required, Display(Name = "Емаил"), EmailAddress]
        public string SenderEmail { get; set; }
        [Required]
        public string Message { get; set; }
    }

}