using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ForumTestDAL.Entities
{
    public class User : IdentityUser
    {
        public virtual UserProfile UserProfile { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Topic> Topics { get; set; }
    }
}
