using Amazon.Lambda.Core;

// This assembly is required to convert json event to lambda object
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace LambdaDotnetInvoke;


public class Function
{
    public string Main()
    {
        return "Hello from dotnet lambda!";
    }
}
