using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add SignalR
builder.Services.AddSignalR();

var app = builder.Build();

// Map Hub
app.MapHub<ChatHub>("/chat");

app.Run();

// Hub Class
public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        // Send message to all clients
        await Clients.All.SendAsync(
            "ReceiveMessage",
            user,
            message);
    }
}