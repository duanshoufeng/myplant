using System.Collections.Generic;
using System.Threading.Tasks;
using API.Resources;
using API.Entities;
using API.Utils;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GerUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberResource>> GetMembersAsync(UserParams userParams);
        Task<MemberResource> GetMemberAsync(string username);
        Task<string> GetUserGender(string username);

    }
}