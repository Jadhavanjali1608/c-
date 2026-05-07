using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Register Background Service
builder.Services.AddHostedService<MyBackgroundService>();

var app = builder.Build();

app.Run();

// Background Worker
public class MyBackgroundService : BackgroundService
{
    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine(
                "Background Task Running: " + DateTime.Now);

            await Task.Delay(5000, stoppingToken);
        }
    }
}