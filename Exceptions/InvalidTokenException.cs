namespace Calculator.Exceptions;
// deriving class from the built in exception class
public class InvalidTokenException : Exception
{
    // creating property to hold the invalid symbol
    public string InvalidSymbol { get; }
    // using base class constructor from built in exception class to pass the error message aswell as the invalid symbol
    public InvalidTokenException(string symbol) : base($"InvalidTokenException: {symbol}")
    {
        InvalidSymbol = symbol;
    }
}
