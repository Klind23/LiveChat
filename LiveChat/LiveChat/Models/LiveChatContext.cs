using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveChat.Models
{
    public class LiveChatContext : IdentityDbContext
    {
        public LiveChatContext() : base("LiveChatContext")
        {

        }

        public static LiveChatContext Create()
        {
            return new LiveChatContext();
        }

        public DbSet <PerdoruesModel> Perdorues { get; set; }
    }
}