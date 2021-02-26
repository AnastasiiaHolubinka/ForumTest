using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ForumTestDAL.EF;
using ForumTestDAL.Entities;
using ForumTestDAL.Interfaces;

namespace ForumTestDAL.Repositories.General
{
    public class UnitOfWork : IUnitOfWork
    {
        private ForumDbContext _dbContext;
        UserManager<User> userManager;
        RoleManager<IdentityRole> roleManager;
        IRepository<UserProfile> userProfileRepository;
        IRepository<Topic> topicRepository;
        IRepository<Forum> forumRepository;
        IRepository<Post> postRepository;

        public UnitOfWork()
        {
            _dbContext = new ForumDbContext();
        }


        #region Properties
        public UserManager<User> UserManager
        {
            get
            {
                if (userManager == null)
                    userManager = new UserManager<User>(new UserStore<User>(_dbContext));
                return userManager;
            }
        }

        public RoleManager<IdentityRole> RoleManager
        {
            get
            {
                if (roleManager == null)
                    roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_dbContext));
                return roleManager;
            }
        }

        public IRepository<UserProfile> UserProfileRepository
        {
            get
            {
                if (userProfileRepository == null)
                    userProfileRepository = new UserProfileRepository(_dbContext);
                return userProfileRepository;
            }
        }

        public IRepository<Topic> TopicRepository
        {
            get
            {
                if (topicRepository == null)
                    topicRepository = new TopicRepository(_dbContext);
                return topicRepository;
            }
        }
        public IRepository<Post> PostRepository
        {
            get
            {
                if (postRepository == null)
                    postRepository = new PostRepository(_dbContext);
                return postRepository;
            }
        }


        public IRepository<Forum> ForumRepository
        {
            get
            {
                if (forumRepository == null)
                    forumRepository = new ForumRepository(_dbContext);
                return forumRepository;
            }
        }
        #endregion

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
