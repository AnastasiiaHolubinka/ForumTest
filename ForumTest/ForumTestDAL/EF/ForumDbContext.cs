using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ForumTestDAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ForumTestDAL.EF
{
    public class ForumDbContext : IdentityDbContext<User>
    {
        public ForumDbContext() : base("ForumConnection")
        {
            Database.SetInitializer(new DbInitializer1());
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
