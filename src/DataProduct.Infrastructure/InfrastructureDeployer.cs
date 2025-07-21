using System.Diagnostics;

namespace DataProduct.Infrastructure
{
    public class InfrastructureDeployer
    {
        /// <summary>
        /// Deploys the specified Bicep file to the provided resource group using the Azure CLI.
        /// </summary>
        public void Deploy(string bicepFile, string resourceGroupName)
        {
            var process = new Process();
            process.StartInfo.FileName = "az";
            process.StartInfo.Arguments = $"deployment group create -g {resourceGroupName} -f {bicepFile}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine(output);
            if (!string.IsNullOrWhiteSpace(error))
            {
                Console.Error.WriteLine(error);
            }
        }
    }
}
