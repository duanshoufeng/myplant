using System.Collections.Generic;
using System.Threading.Tasks;
using API.Resources;
using API.Entities;
using API.Utils;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);

        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeResource>> GetUserLikes(LikesParams likesParams);


    }
}