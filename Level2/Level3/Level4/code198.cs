using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> logger;

    public TestController(
        ILogger<TestController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public IActionResult GetData()
    {
        // Logging
        logger.LogInformation(
            "API Request Received");

        logger.LogWarning(
            "This is Warning Message");

        logger.LogError(
            "This is Error Message");

        return Ok("Logging Working");
    }
}