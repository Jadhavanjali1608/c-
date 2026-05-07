using Azure.Storage.Blobs;
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
    [HttpPost]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        // Connection String
        string connectionString =
            "Your_Azure_Blob_Connection_String";

        // Container Name
        string containerName = "files";

        // Blob Client
        BlobContainerClient container =
            new BlobContainerClient(
                connectionString,
                containerName);

        // Upload File
        BlobClient blob =
            container.GetBlobClient(file.FileName);

        using var stream = file.OpenReadStream();

        await blob.UploadAsync(stream, true);

        return Ok("File Uploaded");
    }
}