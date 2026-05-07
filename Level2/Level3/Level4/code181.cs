using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpClient();

var app = builder.Build();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly HttpClient client;

    public OrderController(IHttpClientFactory factory)
    {
        client = factory.CreateClient();
    }

    [HttpGet]
    public async Task<IActionResult> GetData()
    {
        // Call another microservice API
        string url = "https://localhost:5001/api/product";

        string result = await client.GetStringAsync(url);

        return Ok(result);
    }
}