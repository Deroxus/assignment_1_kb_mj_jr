// using "global::" to show we are referring to our own defined exceptions, not the built-in 
using InvalidOperationException = global::Calculator.Exceptions.InvalidOperationException;
using InvalidTokenException = global::Calculator.Exceptions.InvalidTokenException;

namespace Calculator.Model;

public class RpnCalculator
{
    public double Calculate(string expression)
    {
        // split the expression into parts using spaces as delimiter
        string[] parts = expression.Split(' ');

        // instantiate a new stack
        MyStack stack = new MyStack();

        // loop for all parts of the expression
        foreach (string part in parts)
        {
            // using TryParse to check if part is a number
            if (double.TryParse(part, out double number))
            {
                Operand operand = new Operand(number);
                // push this number
                stack.Push(operand);
            }
            else
            {
                // initialize operator to null
                Operator? operation = null;

                // large if/else statement to find the correct operator
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
                    // if part was not a valid operator, throw error
                    throw new InvalidTokenException(part);
                }

                // push the operator to the stack
                stack.Push(operation);
            }
        }

        // pop the last token from the stack and evaluate
        Token token = stack.Pop();

        double result = token.Evaluate(stack);

        // if the stack is somehow not empty at the end, throw an error
        if (stack.Count != 0)
        {
            throw new InvalidOperationException();
        }
        return result;
    }
}
