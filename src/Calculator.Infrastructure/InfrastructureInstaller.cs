using Calculator.Application.Services;
using Calculator.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Infrastructure;

public static class InfrastructureInstaller
{
    public static IServiceCollection InstallInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<ICalculatorService, CalculatorService>();

        return services;
    }
}
