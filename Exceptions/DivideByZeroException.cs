// this first line ensures that the program uses our own defined DivideByZeroException class instead of the built-in one
using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;

namespace Calculator.Exceptions;
// deriving class from the built in exception class
public class DivideByZeroException : Exception
{
    // creating property to hold error details
    public string ErrorDetails { get; }
    // using base class constructor from built in exception class to pass error message
    public DivideByZeroException(string details) : base($"DivideByZeroException: {details}")
    {
        ErrorDetails = details;
    }
}
