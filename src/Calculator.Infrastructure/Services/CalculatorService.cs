using Calculator.Application.Services;
using Calculator.Domain;

namespace Calculator.Infrastructure.Services;

public class CalculatorService : ICalculatorService
{
    private readonly Dictionary<char, Func<int, int, float>> operations;

    public CalculatorService()
    {
        operations = new Dictionary<char, Func<int, int, float>>
        {
            { '+', (x, y) => x + y },
            { '-', (x, y) => x - y },
            { '*', (x, y) => x * y },
            { '/', Division }
        };
    }

    public ResultFormulaDto Calculate(FormulaDto formula)
    {
        if (!operations.ContainsKey(formula.Sign))
            throw new ArgumentException("Invalid sign");

        var result = operations[formula.Sign](formula.X, formula.Y);

        return new()
        { 
            X = formula.X, 
            Y = formula.Y, 
            Sign = formula.Sign, 
            Result = result
        };
    }

    private float Division(int x, int y)
    {
        if (y == 0)
            throw new ArgumentException("Cannot divide by zero");

        return (float)x / y;
    }
}
