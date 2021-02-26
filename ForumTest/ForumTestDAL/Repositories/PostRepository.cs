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
    public class PostRepository : BaseRepository<Post>
    {
        public PostRepository(ForumDbContext dbContext) : base(dbContext)
        {
        }
    }
}
