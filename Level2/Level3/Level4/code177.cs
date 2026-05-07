using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Controller
[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    // File Upload
    [HttpPost("upload")]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        string path = Path.Combine("Uploads", file.FileName);

        using (var stream = new FileStream(path, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return Ok("File Uploaded");
    }

    // File Download
    [HttpGet("download")]
    public IActionResult Download()
    {
        string path = Path.Combine("Uploads", "sample.txt");

        byte[] bytes = System.IO.File.ReadAllBytes(path);

        return File(bytes,
            "application/octet-stream",
            "sample.txt");
    }
}