using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Model
public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    [HttpPost]
    public IActionResult Login(LoginModel model)
    {
        // Input Validation
        if (string.IsNullOrWhiteSpace(
            model.Username) ||
            string.IsNullOrWhiteSpace(
            model.Password))
        {
            return BadRequest("Invalid Input");
        }

        // Secure Response
        return Ok("Login Success");
    }
}