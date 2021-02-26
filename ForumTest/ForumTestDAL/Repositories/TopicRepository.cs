using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestDAL.Entities;
using ForumTestDAL.Repositories.General;
using ForumTestDAL.EF;

namespace ForumTestDAL.Repositories
{
    public class TopicRepository : BaseRepository<Topic>
    {
        public TopicRepository(ForumDbContext dbContext) : base(dbContext)
        {
        }
    }
}
