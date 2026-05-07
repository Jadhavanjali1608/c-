using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Swagger Service
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Student API",
            Version = "v1"
        });
});

var app = builder.Build();

// Enable Swagger
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json",
                      "Student API V1");
});

app.MapControllers();

app.Run();

// Controller
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public IActionResult GetStudent()
    {
        return Ok(new
        {
            Id = 1,
            Name = "Anjali"
        });
    }
}