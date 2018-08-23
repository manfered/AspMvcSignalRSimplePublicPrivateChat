using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using AspMvcSignalRSimplePublicChat.Models;

namespace AspMvcSignalRSimplePublicChat.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public void Send(string senderName, string receiverID, string message)
        {
            Clients.User(receiverID).send(senderName, receiverID, message);
        }

        public void AllChatMessage(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}