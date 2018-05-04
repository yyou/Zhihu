using System.Collections.Generic;
using System.Threading.Tasks;
using Zhihu.Core.Models.Permissions;

namespace Zhihu.Core.Services.Permissions
{
    public interface IPermissionsService
    {
        Task<PermissionStatus> CheckPermissionStatusAsync(Permission permission);
        Task<Dictionary<Permission, PermissionStatus>> RequestPermissionsAsync(params Permission[] permissions);
    }
}
