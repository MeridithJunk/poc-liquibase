using DataProduct.Infrastructure;

Console.WriteLine("Deploying infrastructure...");
var deployer = new InfrastructureDeployer();
deployer.Deploy("../DataProduct.Infrastructure/main.bicep", "DataProduct-RG");
Console.WriteLine("Done.");
