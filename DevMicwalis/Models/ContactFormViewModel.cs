using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevMicwalis.Models
{
    public class ContactFormViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required, Display(Name = "Email Address"), EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}