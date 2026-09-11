namespace Calculator.Exceptions;
public class InvalidTokenException : Exception
{
    public string InvalidSymbol { get; }

    public InvalidTokenException(string message, string symbol) : base(message)
    {
        InvalidSymbol = symbol;
    }
}
