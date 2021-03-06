using System;
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        public string LoginPassword { get; set; }
    }
}