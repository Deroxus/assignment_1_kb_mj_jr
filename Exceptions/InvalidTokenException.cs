namespace Calculator.Exceptions;
public class InvalidTokenException : Exception
{
    public string InvalidSymbol { get; }

    public InvalidTokenException(string symbol) : base($"InvalidTokenException: {symbol}")
    {
        InvalidSymbol = symbol;
    }
}
