using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
        public DbSet <RegisterModel> Register { get; set; }
        public DbSet <RoomModel> Room { get; set; }
        public DbSet <ChatModel> Chat { get; set; }
       
    }
}