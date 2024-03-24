namespace Calculator.Domain;

public record ResultFormulaDto
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Sign { get; set; }
    public float Result { get; set; }

    public override string ToString()
    {
        return $"{X} {Sign} {Y} = {Result}";
    }
}
