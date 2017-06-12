using System.Threading.Tasks;
using Abp.Application.Services;
using AbpDemo.Roles.Dto;

namespace AbpDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
