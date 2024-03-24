using Calculator.Domain;

namespace Calculator.Application.Services;

public interface ICalculatorService
{
    ResultFormulaDto Calculate(FormulaDto formula);
}
