using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestBLL.DTO;
using ForumTestBLL.Infrastructure;

namespace ForumTestBLL.Interfaces
{
    public interface IForumService
    {
        IEnumerable<ForumDTO> GetAll();
        ForumDTO GetById(int id);
        OperationDetails Create(ForumDTO forumDto);
        Task<OperationDetails> Delete(ForumDTO forumDto);
        OperationDetails UpdateForum(ForumDTO forumDto);
        void Dispose();

    }
}
