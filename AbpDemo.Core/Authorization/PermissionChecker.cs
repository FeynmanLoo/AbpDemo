using Abp.Authorization;
using AbpDemo.Authorization.Roles;
using AbpDemo.MultiTenancy;
using AbpDemo.Users;

namespace AbpDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
