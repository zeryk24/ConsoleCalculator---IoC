using Calculator.Application;
using Calculator.Application.Add;
using Calculator.Application.Services;
using Calculator.Application.Subtract;
using Calculator.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Presentation;

public class RequestFacade(CalculatorRequestHandlerFactory factory) : IRequestFacade
{

    public ResultFormulaDto SendRequest(int x, int y, char sign)
    {
        IRequestHandler handler = factory.CreateHandler(sign);
        return handler.Handle(x,y);
    }
}

public class CalculatorRequestHandlerFactory(IServiceProvider serviceProvider)
{
    public IRequestHandler CreateHandler(char sign)
    {
        return sign switch
        {
            '+' => serviceProvider.GetRequiredService<AddRequestHandler>(),
            '-' => serviceProvider.GetRequiredService<SubtractRequestHandler>(),
            _ => throw new NotImplementedException(),
        };
    }
}
