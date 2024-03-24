using Calculator.Application;
using Calculator.Application.Add;
using Calculator.Application.Services;
using Calculator.Application.Subtract;
using Calculator.Domain;

namespace Calculator.Presentation;

public class RequestFacade(ICalculatorService calculatorService) : IRequestFacade
{

    public ResultFormulaDto SendRequest(int x, int y, char sign)
    {
        var factory = new CalculatorRequestHandlerFactory(calculatorService);
        IRequestHandler handler = factory.CreateHandler('+');
        return handler.Handle(x,y);
    }
}

public class CalculatorRequestHandlerFactory(ICalculatorService calculatorService)
{
    public IRequestHandler CreateHandler(char sign)
    {
        return sign switch
        {
            '+' => new AddRequestHandler(calculatorService),
            '-' => new SubtractRequestHandler(calculatorService),
            _ => throw new NotImplementedException(),
        };
    }
}
