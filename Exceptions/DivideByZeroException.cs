using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;
namespace Calculator.Exceptions
{
    public class DivideByZeroException : Exception
    {
        public string ErrorDetails { get; }
        public DivideByZeroException(string message, string details) : base(message)
        {
            ErrorDetails = details;
        }
    }
}
