using FaturatHermes.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;

namespace FaturatHermes.Infrastructure
{
    public class ApplicationRoleManager : RoleManager<RoleModel,Guid>
    {
        public ApplicationRoleManager(IRoleStore<RoleModel, Guid> roleStore)
            : base(roleStore)
        {
        }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            var appRoleManager = new ApplicationRoleManager(new RoleStore<RoleModel,Guid,UserRoleModel>(context.Get<HermesContext>()));

            return appRoleManager;
        }
    }
}
