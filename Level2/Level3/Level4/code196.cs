using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Response Compression
builder.Services.AddResponseCompression();

// Memory Cache
builder.Services.AddMemoryCache();

builder.Services.AddControllers();

var app = builder.Build();

app.UseResponseCompression();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private readonly IMemoryCache cache;

    public DataController(IMemoryCache cache)
    {
        this.cache = cache;
    }

    [HttpGet]
    public IActionResult GetData()
    {
        // Check Cache
        if (!cache.TryGetValue(
            "data", out string result))
        {
            // Heavy Data
            result = "Fast API Response";

            // Store Cache
            cache.Set("data", result);
        }

        return Ok(result);
    }
}