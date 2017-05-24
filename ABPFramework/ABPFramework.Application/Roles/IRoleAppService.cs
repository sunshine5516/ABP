using System.Threading.Tasks;
using Abp.Application.Services;
using ABPFramework.Roles.Dto;

namespace ABPFramework.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
