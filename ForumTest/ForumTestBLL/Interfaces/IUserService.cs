using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumTestBLL.DTO;
using ForumTestBLL.Infrastructure;
using System.Security.Claims;

namespace ForumTestBLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserDTO userDto);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        OperationDetails UpdateRoles(UserDTO userDto);
        IEnumerable<UserDTO> GetAll();
        UserDTO Find(string userName);
    }
}
