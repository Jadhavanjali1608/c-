using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add controller service
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    // GET API
    [HttpGet]
    public IActionResult GetStudent()
    {
        return Ok(new
        {
            Id = 1,
            Name = "Anjali",
            Course = "BTech"
        });
    }
}