using Miclea_Adela_Laborator2.Models;
using Microsoft.AspNetCore.SignalR;
namespace Miclea_Adela_Laborator2.Hubs
{
    public class ChatHub:Hub
    { 
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}

}
