using Microsoft.ApplicationInsights.Extensibility;

var builder = WebApplication.CreateBuilder(args);

// Application Insights
builder.Services.AddApplicationInsightsTelemetry(
    "Your_Instrumentation_Key");

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Application Running";
});

app.Run();