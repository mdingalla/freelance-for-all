using System.Threading.Tasks;
using Abp.Application.Services;
using FreelanceForAll.Roles.Dto;

namespace FreelanceForAll.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
