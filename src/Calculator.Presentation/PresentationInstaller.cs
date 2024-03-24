using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Presentation;

public static class PresentationInstaller
{
    public static IServiceCollection InstallPresentation(this IServiceCollection services)
    {
        services.AddTransient<RequestFacade>();
        services.AddTransient<CalculatorRequestHandlerFactory>();

        return services;
    }
}
