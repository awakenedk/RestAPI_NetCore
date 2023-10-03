using Microsoft.AspNetCore.Hosting;

namespace RestAPI_NetCore
{
    public class LambdaFunction : Amazon.Lambda.AspNetCoreServer.APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<StartupBase>()
                .UseLambdaServer();
        }
    }


}
