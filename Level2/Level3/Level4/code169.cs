using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey =
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("MySecretKey123"))
    };
});

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    [HttpGet]
    public IActionResult Login()
    {
        // Create Token
        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("MySecretKey123"));

        var creds = new SigningCredentials(
            key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            claims: new[]
            {
                new Claim(ClaimTypes.Name, "Anjali")
            },
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds
        );

        string jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return Ok(jwt);
    }

    // Protected API
    [Authorize]
    [HttpGet("data")]
    public IActionResult GetData()
    {
        return Ok("Secure Data");
    }
}