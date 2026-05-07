using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

// Azure Key Vault
builder.Configuration.AddAzureKeyVault(
    new Uri("https://myvault.vault.azure.net/"),
    new DefaultAzureCredential());

var app = builder.Build();

// Read Secret
string secret =
    builder.Configuration["MySecretKey"];

app.MapGet("/", () => secret);

app.Run();