using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// Global Exception Middleware
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        context.Response.StatusCode = 500;

        await context.Response.WriteAsJsonAsync(
            new
            {
                Message = "Internal Server Error",
                Error = ex.Message
            });
    }
});

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult GetData()
    {
        throw new Exception("Database Failed");
    }
}