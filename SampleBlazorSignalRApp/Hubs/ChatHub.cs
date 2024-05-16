using Microsoft.AspNetCore.SignalR;

namespace SampleBlazorSignalRApp.Hubs;
	public class ChatHub : Hub
	{
	    public async Task SendMessage(string message, string user)
		{
		  await Clients.All.SendAsync("ReceiveMessage", user, message);
		}
	}

