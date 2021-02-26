using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ForumTest.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter login")]
        [Display(Name = "Login")]
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
        
        public DateTime RegistrationDate { get; set; }
    }
}