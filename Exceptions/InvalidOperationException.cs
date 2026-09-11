namespace Calculator.Exceptions;
public class InvalidOperationException : Exception
{
    public string ErrorDetails { get; }
    public InvalidOperationException(string details)
    {
        ErrorDetails = details;
    }
}
