using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using ForumTestDAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ForumTestDAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        UserManager<User> UserManager { get; }
        RoleManager<IdentityRole> RoleManager { get; }
        IRepository<UserProfile> UserProfileRepository { get; }
        IRepository<Topic> TopicRepository { get; }
        IRepository<Forum> ForumRepository { get; }
        IRepository<Post> PostRepository { get; }

        Task SaveAsync();
        void Save();
    }
}
