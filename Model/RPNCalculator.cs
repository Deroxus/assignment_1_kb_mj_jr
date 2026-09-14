using InvalidOperationException = global::Calculator.Exceptions.InvalidOperationException;

using InvalidTokenException = global::Calculator.Exceptions.InvalidTokenException;

namespace Calculator.Model;

public class RpnCalculator
{
    public double Calculate(string expression)
    {
        string[] parts = expression.Split(' ');

        MyStack stack = new MyStack();

        foreach (string part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                Operand operand = new Operand(number);
                stack.Push(operand);
            }
            else
            {
                Operator? operation = null;

                if (part == "+")
                { operation = new SumOperator(); }
                else if (part == "-")
                { operation = new SubtractOperator(); }
                else if (part == "*")
                { operation = new MultiplyOperator(); }
                else if (part == "/")
                { operation = new DivideOperator(); }
                else if (part == "%")
                { operation = new ModulusOperator(); }

                else
                {
                    throw new InvalidTokenException(part);
                }

                stack.Push(operation);
            }
        }

        Token token = stack.Pop();

        double result = token.Evaluate(stack);

        if (stack.Count != 0)
        {
            throw new InvalidOperationException();
        }
        return result;
    }
}
