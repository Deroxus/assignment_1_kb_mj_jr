// this first line ensures the program uses our own defined DivideByZeroException class instead of the built-in one
using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;

namespace Calculator.Model;

public class DivideOperator : Operator
{
    // using the override keyword to provide a specific implementation of the Calculate method for division
    public override double Calculate(double leftOperand, double rightOperand)
    {
        if (rightOperand == 0)
        {
            // the "F2" format specifier ensures the output is showing two decimals for both operands
            throw new DivideByZeroException(leftOperand.ToString("F2") + "/" + rightOperand.ToString("F2"));
        }
        return leftOperand / rightOperand;
    }
    public override string ToString()
    {
        return "/";
    }
}
