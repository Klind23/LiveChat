using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LiveChat.Models
{
    public class LivechatContext : IdentityDbContext<UserModel, RoleModel, Guid, UserLoginModel, UserRoleModel, UserClaimModel>
    {
        public LivechatContext() : base("LivechatContext")
        {

        }



        public static LivechatContext Create()
        {
            return new LivechatContext();
        }

        //public DbSet<ChatModel> Chat { get; set; }
        public DbSet<PerdoruesModel> Perdorues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}