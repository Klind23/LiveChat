using FaturatHermes.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;

namespace FaturatHermes.Infrastructure
{
    public class ApplicationUserManager : UserManager<UserModel, Guid>
    {
        public ApplicationUserManager(IUserStore<UserModel, Guid> store) : base(store) { }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var appDbContext = context.Get<HermesContext>();
            var appUserManager = new ApplicationUserManager(new UserStore<UserModel, RoleModel, Guid, UserLoginModel, UserRoleModel, UserClaimModel>(appDbContext));
			appUserManager.UserValidator = new UserValidator<UserModel, Guid>(appUserManager)
			{
				AllowOnlyAlphanumericUserNames = true,
				RequireUniqueEmail = true
			};
			appUserManager.PasswordValidator = new PasswordValidator
			{
				RequiredLength = 6,
				RequireNonLetterOrDigit = true,
				RequireDigit = false,
				RequireLowercase = true,
				RequireUppercase = true,
			};
			return appUserManager;

        }
    }
}
