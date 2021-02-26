using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestDAL.EF;
using ForumTestDAL.Entities;
using ForumTestDAL.Repositories.General;

namespace ForumTestDAL.Repositories
{
    public class ForumRepository : BaseRepository<Forum>
    {
        public ForumRepository(ForumDbContext dbContext) : base(dbContext)
        {
        }
    }
}
