# DataProduct Sample

This repository contains a simple C# console application demonstrating a data product structure with an infrastructure layer for Azure. It targets **.NET 9**.

## Projects

- **DataProduct** – Console application that triggers deployment of infrastructure.
- **DataProduct.Infrastructure** – Library containing utilities and a Bicep file for deploying Azure resources.
- **DataProduct.Domain** – Domain objects and interfaces used by the application.

The `InfrastructureDeployer` class wraps calls to the Azure CLI to deploy the provided Bicep template.

## Deploying

1. Ensure the [Azure CLI](https://learn.microsoft.com/cli/azure/install-azure-cli) is installed and logged in.
2. Execute the `DataProduct` application. It will run `az deployment group create` using the included `main.bicep` template.

```bash
# Build and run (requires .NET 9 SDK)
dotnet run --project src/DataProduct/DataProduct.csproj
```

This will create a storage account within the specified resource group.
