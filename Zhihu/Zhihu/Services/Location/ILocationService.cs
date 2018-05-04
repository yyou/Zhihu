using System.Threading.Tasks;

namespace Zhihu.Core.Services.Location
{    
    public interface ILocationService
    {
        Task UpdateUserLocation(Zhihu.Core.Models.Location.Location newLocReq, string token);
    }
}