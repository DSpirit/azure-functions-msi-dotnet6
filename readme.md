# Using Azure Functions with Managed Identity
[docs.microsoft.com](https://docs.microsoft.com/en-us/azure/azure-functions/functions-identity-based-connections-tutorial)
> This tutorial shows you how to configure a function app using Azure Active Directory identities instead of secrets or connection strings, where possible. Using identities helps you avoid accidentally leaking sensitive secrets and can provide better visibility into how data is accessed. To learn more about identity-based connections, see configure an identity-based connection.

## AzureWebJobsStorage (Primary Function Storage)
[docs.microsoft.com](https://docs.microsoft.com/en-us/azure/azure-functions/functions-identity-based-connections-tutorial#edit-the-azurewebjobsstorage-configuration)

## Azure Storage
[docs.microsoft.com](https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-storage-blob-trigger?tabs=in-process%2Cextensionv5&pivots=programming-language-csharp#identity-based-connections)

## Azure Service Bus
[docs.microsoft.com](https://docs.microsoft.com/en-us/azure/azure-functions/functions-identity-based-connections-tutorial-2#connect-to-service-bus-in-your-function-app)

## local.settings.json
``` json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "APPINSIGHTS_INSTRUMENTATIONKEY": "*",
    "APPLICATIONINSIGHTS_CONNECTION_STRING": "*",
    "AzureWebJobsServiceBus__fullyQualifiedNamespace": "*.servicebus.windows.net",
    "AzureWebJobsStorage__accountName": "*",
    "FUNCTIONS_EXTENSION_VERSION": "~4",
    "Payloads__serviceUri": "https://*.blob.core.windows.net"
  }
}

```

# Links
[Currently supported components](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference?tabs=blob#configure-an-identity-based-connection)