using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class SiteChatHub:Hub
    {
        public async Task SendNewMessage(string sender,string Message)
        {
          await  Clients.All.SendAsync("getNewMessage", sender, Message, DateTime.Now.ToShortDateString());
        }
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
