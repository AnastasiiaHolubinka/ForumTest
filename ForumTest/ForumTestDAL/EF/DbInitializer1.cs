using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ForumTestDAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ForumTestDAL.EF
{
    public class DbInitializer1 : DropCreateDatabaseIfModelChanges<ForumDbContext>
    {
        protected override void Seed(ForumDbContext db)
        {

            Forum csharp = db.Forums.Add(new Forum { Name = "C#", Description = "C# (pronounced C sharp) is an object-oriented programming language that is designed for building a variety of applications that run on the .NET Framework. C# is simple." });
            Forum js = db.Forums.Add(new Forum { Name = "JavaScript", Description = "JavaScript (not to be confused with Java) is a dynamic, weakly-typed language used for both client-side and server-side scripting. " });
            Forum cpp = db.Forums.Add(new Forum { Name = "C++", Description = "C++ is a general-purpose programming language. It was originally designed as an extension to C, and keeps a similar syntax, but is now a completely different language." });
            Forum python = db.Forums.Add(new Forum { Name = "Python", Description = "Python is a dynamic and strongly typed programming language designed to emphasize usability." });
            Forum java = db.Forums.Add(new Forum { Name = "Java", Description = "Java (not to be confused with JavaScript or JScript) is a general-purpose object-oriented programming language " });
            Forum test = db.Forums.Add(new Forum { Name = "Test", Description = "TEST" });
            db.Forums.AddRange(new List<Forum> { csharp, js, cpp, python, java, test });

            Topic topic1 = db.Topics.Add(new Topic { Title = "Set cell size in Google sheets using Java API", Description = "Проблема з цим...", Forum = java, CreationDate = DateTime.Now, UserName = "User" });
            Topic topic2 = db.Topics.Add(new Topic { Title = "Java how not to print string from for loop? (ARRAY)", Description = "Проблема з цим...", Forum = java, CreationDate = DateTime.Now, UserName = "User" });
            Topic topic3 = db.Topics.Add(new Topic { Title = "How not to print string from for loop? (ARRAY)", Description = "Проблема з цим...", Forum = csharp, CreationDate = DateTime.Now, UserName = "User" });
            Topic topic4 = db.Topics.Add(new Topic { Title = "Set cell size in Google sheets using API", Description = "Проблема з цим...", Forum = csharp, CreationDate = DateTime.Now, UserName = "User" });
            List<Topic> threadList = new List<Topic>() { topic1, topic2, topic3, topic4 };

            Post post1 = db.Posts.Add(new Post { Message = "I have a recyclerview with multiple items. and recyclerview has different viewtypes with different heights..", Topic = topic2, UserName = "User", PostTime = DateTime.Now });
           
            List<Post> postList = new List<Post>() { post1 };

            var userManager = new UserManager<User>(new UserStore<User>(db));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            var role1 = new IdentityRole { Name = "Administrator" };
            var role3 = new IdentityRole { Name = "User" };


            roleManager.Create(role1);
            roleManager.Create(role3);


            string password = "123qwerT";

            var adminUser = new User() { Email = "admin@forum.com", UserName = "Administrator" };
            var userUser = new User() { Email = "user@forum.com", UserName = "User" };

            var result1 = userManager.Create(adminUser, password);
            var result3 = userManager.Create(userUser, password);


            if (result1.Succeeded)
            {
                userManager.AddToRole(adminUser.Id, role1.Name);
                userManager.AddToRole(adminUser.Id, role3.Name);
            }

            if (result3.Succeeded)
            {
                userManager.AddToRole(userUser.Id, role3.Name);
            }

            db.SaveChanges();
        }

    }
}
