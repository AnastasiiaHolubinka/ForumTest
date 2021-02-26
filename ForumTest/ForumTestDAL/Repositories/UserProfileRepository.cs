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
    public class UserProfileRepository : BaseRepository<UserProfile>
    {
        public UserProfileRepository(ForumDbContext dbContext) : base(dbContext)
        {
        }
    }
}
