# Build Application
dotnet build

# Publish Application
dotnet publish -c Release -o publish

# Build Docker Image
docker build -t myapp .

# Run Docker Container
docker run -p 8080:80 myapp

# Deploy to Azure
az webapp deploy \
--resource-group MyGroup \
--name mydotnetapp123 \
--src-path ./publish.zip