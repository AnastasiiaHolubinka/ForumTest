using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestBLL.DTO;
using ForumTestBLL.Infrastructure;

namespace ForumTestBLL.Interfaces
{
    public interface ITopicService
    {
        OperationDetails Create(TopicDTO threadDto);
        Task<OperationDetails> Delete(TopicDTO threadDto);
        IEnumerable<TopicDTO> GetAllTopicsByForum(int forumId);
        IEnumerable<TopicDTO> GetAllTopicsByAuthor(string userName);
        IEnumerable<TopicDTO> GetAll();
        TopicDTO GetById(int topicId);
        void Dispose();
    }
}
