namespace Calculator.Exceptions;
// deriving class from the built in exception class
public class InvalidOperationException : Exception
{
    // this specific exception does not require a message, therefore no property or parameters are needed
    public InvalidOperationException() : base("InvalidOperationException")
    { }
}
