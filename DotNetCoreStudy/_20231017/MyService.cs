namespace DotNetCoreStudy._20231017;

using Microsoft.Extensions.DependencyInjection;

public interface IMyService
{
    string GetServiceName();
}

public class MyService : IMyService
{
    public string GetServiceName()
    {
        return "This is MyService.";
    }
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IMyService, MyService>();
    }
}