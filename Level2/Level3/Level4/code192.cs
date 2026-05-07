using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class TenantController : ControllerBase
{
    [HttpGet]
    public IActionResult GetData(
        [FromHeader] string tenantId)
    {
        // Tenant-based response
        if (tenantId == "T1")
        {
            return Ok("Data for Tenant 1");
        }

        if (tenantId == "T2")
        {
            return Ok("Data for Tenant 2");
        }

        return BadRequest("Invalid Tenant");
    }
}