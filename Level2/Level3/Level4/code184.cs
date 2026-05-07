# Login Azure
az login

# Create Resource Group
az group create --name MyGroup --location centralindia

# Create App Service Plan
az appservice plan create \
--name MyPlan \
--resource-group MyGroup \
--sku FREE

# Create Web App
az webapp create \
--resource-group MyGroup \
--plan MyPlan \
--name mydotnetapp123 \
--runtime "DOTNET:8"

# Deploy Application
az webapp deploy \
--resource-group MyGroup \
--name mydotnetapp123 \
--src-path ./publish.zip