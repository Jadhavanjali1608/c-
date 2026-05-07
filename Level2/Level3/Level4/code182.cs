# Base Image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# App Directory
WORKDIR /app

# Copy Files
COPY . .

# Run Application
ENTRYPOINT ["dotnet", "MyApp.dll"]