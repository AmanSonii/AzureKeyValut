using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace AzureKeyVault
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyVaultUrl = "";
            string clientId = "";
            string clientSecret = "";
            string tenantId = "";

            var clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var client = new SecretClient(new Uri(keyVaultUrl), clientSecretCredential);

            KeyVaultSecret secret = client.GetSecret("SecretNAME");
        }
    }
}
