using Calculator.Domain;

namespace Calculator.Presentation
{
    public interface IRequestFacade
    {
        ResultFormulaDto SendRequest(int x, int y, char sign);
    }
}