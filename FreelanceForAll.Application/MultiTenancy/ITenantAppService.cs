using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FreelanceForAll.MultiTenancy.Dto;

namespace FreelanceForAll.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
