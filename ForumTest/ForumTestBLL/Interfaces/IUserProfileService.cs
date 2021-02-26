using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestBLL.DTO;
using ForumTestBLL.Infrastructure;

namespace ForumTestBLL.Interfaces
{
    public interface IUserProfileService
    {
        Task<OperationDetails> UpdateUserProfileAsync(UserProfileDTO userProfileDto);
        Task<UserProfileDTO> FindByNameAsync(string userName);
    }
}
