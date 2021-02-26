using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTestBLL.Interfaces
{
    public interface IServiceBag : IDisposable
    {
        IForumService ForumService { get; }
        ITopicService TopicService { get; }
        IPostService PostService { get; }
        IUserService UserService { get; }
        IUserProfileService UserProfileService { get; }
    }
}
