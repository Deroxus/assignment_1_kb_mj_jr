// using "global::" prefix to provide information that it's the namespace, not the class name
using global::Calculator.Exceptions;

namespace Calculator.Model;

// deriving from superclass Token   
public abstract class Operator : Token
{
    // creating an abstract method that will be implemented in the future subclasses
    public abstract double Calculate(double leftOperand, double rightOperand);
    public override double Evaluate(MyStack stack)
    {
        // checking if there are enough operands to perform calculations
        if (stack.Count < 2)
        {
            throw new InvalidOperationException();
        }

        Token rightToken = stack.Pop();
        double right = rightToken.Evaluate(stack);

        if (stack.Count < 1)
        {
            throw new InvalidOperationException();
        }

        Token leftToken = stack.Pop();
        double left = leftToken.Evaluate(stack);

        return Calculate(left, right);
    }
}
