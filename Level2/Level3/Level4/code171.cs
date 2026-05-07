using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Exception Handling Middleware
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        context.Response.StatusCode = 500;

        await context.Response.WriteAsync(
            "Error: " + ex.Message);
    }
});

// Test API
app.MapGet("/", () =>
{
    throw new Exception("Something went wrong");
});

app.Run();