using System;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace LiveChat
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
        public void NewMessage(string username, string message)
        {
            Clients.Others.sentMessage(username, message, DateTime.Now);
        }
    }
}