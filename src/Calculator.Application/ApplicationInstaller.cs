using Calculator.Application.Add;
using Calculator.Application.Subtract;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Application;

public static class ApplicationInstaller
{
    public static IServiceCollection InstallApplication(this IServiceCollection services)
    {
        services.AddTransient<AddRequestHandler>();
        services.AddTransient<SubtractRequestHandler>();

        return services;
    }
}
