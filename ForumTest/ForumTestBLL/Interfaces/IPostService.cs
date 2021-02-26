using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestBLL.DTO;
using ForumTestBLL.Infrastructure;

namespace ForumTestBLL.Interfaces
{
    public interface IPostService
    {
        OperationDetails Create(PostDTO postDto);
        Task<OperationDetails> Delete(PostDTO postDto);
        IEnumerable<PostDTO> GetPostsOfTopic(int topicId);
        PostDTO GetById(int postId);
        void Dispose();
    }
}
