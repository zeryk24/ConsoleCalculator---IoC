using Calculator.Domain;

namespace Calculator.Application
{
    public interface IRequestHandler
    {
        ResultFormulaDto Handle(int x, int y);
    }
}