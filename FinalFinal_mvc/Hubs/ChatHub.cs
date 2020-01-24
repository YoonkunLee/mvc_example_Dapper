using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FinalFinal_mvc.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ForwardToClients", user, message);
        }

        public async Task SendMessage1(string user, string email, string gender, string date)
        {
            await Clients.All.SendAsync("ForwardToClients", user, gender, email, date);
        }
    }
}
