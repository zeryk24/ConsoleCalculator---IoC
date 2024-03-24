using Calculator.Application.Services;
using Calculator.Domain;

namespace Calculator.Application.Add;

public class AddRequestHandler(ICalculatorService calculatorService) : IRequestHandler
{
    public ResultFormulaDto Handle(int x, int y)
    {
        var formula = new FormulaDto() { X = x, Y = y, Sign = '+' };

        var result = calculatorService.Calculate(formula);

        return result;
    }
}
