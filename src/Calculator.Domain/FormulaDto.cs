namespace Calculator.Domain;

public record FormulaDto
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Sign { get; set; }
}
