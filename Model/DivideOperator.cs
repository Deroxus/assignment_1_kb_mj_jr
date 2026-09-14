using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;
//using global::Calculator.Exceptions;
namespace Calculator.Model;

public class DivideOperator : Operator
{
    public override double Calculate(double leftOperand, double rightOperand)
    {
        if (rightOperand == 0)
        {
            throw new DivideByZeroException(leftOperand.ToString("F2") + "/" + rightOperand.ToString("F2"));
        }
        return leftOperand / rightOperand;
    }
    public override string ToString()
    {
        return "/";
    }
}
