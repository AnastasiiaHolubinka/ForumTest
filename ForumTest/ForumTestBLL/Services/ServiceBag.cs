using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestBLL.Interfaces;
using ForumTestDAL.Interfaces;

namespace ForumTestBLL.Services
{
    public class ServiceBag : IServiceBag
    {
        IUnitOfWork unitOfWork;

        public ServiceBag(IUnitOfWork UnitOfWork)
        {
            unitOfWork = UnitOfWork;
        }

        #region Properties
        public IForumService ForumService
        {
            get
            {
                return new ForumService(unitOfWork);
            }
        }

        public ITopicService TopicService
        {
            get
            {
                return new TopicService(unitOfWork);
            }
        }

        public IPostService PostService
        {
            get
            {
                return new PostService(unitOfWork);
            }
        }

        public IUserService UserService
        {
            get
            {
                return new UserService(unitOfWork);
            }
        }

        public IUserProfileService UserProfileService
        {
            get
            {
                return new UserProfileService(unitOfWork);
            }
        }
        #endregion

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
