using Microsoft.AspNetCore.SignalR;

namespace DotNetTrainingBatch4.RealtimeChartApp.Hubs
{
    public class ChatHub : Hub
    {
        // Send Message
        public async Task ServerReceiveMessage(string user, string message)
        {
            await Clients.All.SendAsync("ClientReceiveMessage", user, message);
        }
    }
}
