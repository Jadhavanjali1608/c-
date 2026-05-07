using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

var builder = WebApplication.CreateBuilder(args);

// Redis Cache
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IDistributedCache cache;

    public StudentController(IDistributedCache cache)
    {
        this.cache = cache;
    }

    [HttpGet]
    public async Task<IActionResult> GetData()
    {
        // Check cache
        string data = await cache.GetStringAsync("student");

        if (data == null)
        {
            // Fake database data
            data = "Anjali BTech Student";

            // Save in cache
            await cache.SetStringAsync("student", data);
        }

        return Ok(data);
    }
}