using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat_App_RealTime.Hubs
{
    public class ChatHub : Hub        // inherit this
    {
        public Task SendMessage1(string user, string message)               // Two parameters accepted
        {
            return Clients.All.SendAsync("ReceiveOne", user, message);    // Note this 'ReceiveOne' 
        }
    }
}
