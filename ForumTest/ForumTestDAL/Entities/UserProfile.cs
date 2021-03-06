﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ForumTestDAL.Entities
{
    public class UserProfile : Entity
    {
        [Required]
        public User User { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        
        public DateTime? RegistrationDate { get; set; }




    }
}
