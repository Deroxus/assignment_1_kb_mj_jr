namespace Calculator.Model;

using global::Calculator.Exceptions;

public abstract class Operator : Token
{
    public abstract double Calculate(double leftOperand, double rightOperand);
    public override double Evaluate(MyStack stack)
    {
        if (stack.Count < 2)
        {
            throw new InvalidOperationException("InvalidOperationException");
        }

        Token rightToken = stack.Pop();
        double right = rightToken.Evaluate(stack);

        if (stack.Count < 2)
        {
            throw new InvalidOperationException("InvalidOperationException");
        }

        Token leftToken = stack.Pop();
        double left = leftToken.Evaluate(stack);

        return Calculate(left, right);
    }
}
