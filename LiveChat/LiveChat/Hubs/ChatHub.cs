using System;
using System.Linq;
using System.Threading.Tasks;
using LiveChat.Models;
using Microsoft.AspNet.SignalR;
using System.Data.Entity;

namespace LiveChat
{
    public class ChatHub : Hub
    {
        LiveChatContext chatContext = new LiveChatContext();

        public override Task OnConnected()
        {
            Clients.Caller.initMessage(chatContext.Chat.Include(x => x.perdorues).OrderByDescending(x => x.kohaMesazhit).Take(10).OrderBy(x=>x.kohaMesazhit).Select(x => new { x.mesazhi, x.kohaMesazhit, x.perdorues.username }).ToList());
            return base.OnConnected();
        }


        public void NewMessage(string username, string message)
        {
            var user = chatContext.Perdorues.Where(x => x.username == username).FirstOrDefault();

            ChatModel chat = chatContext.Chat.Create();
            chat.kohaMesazhit = DateTime.Now;
            chat.mesazhi = message;
            chat.perdorues = user;
            chatContext.Chat.Add(chat);
            chatContext.SaveChanges();

            Clients.Others.sentMessage(username, message, DateTime.Now);
        }
    }
}