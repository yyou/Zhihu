using Zhihu.Core.Models.User;
using System.Threading.Tasks;

namespace Zhihu.Core.Services.User
{
    public interface IUserService
    {
        Task<UserInfo> GetUserInfoAsync(string authToken);
    }
}
