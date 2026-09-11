namespace Calculator.Controller;

using global::Calculator.Model;
using global::Calculator.Exceptions;
public class CalculatorController
{
    // run method
    // will hold the big loop that asks the user for input and passes it to the Model
    public void Run(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter an RPN expression <return> (empty string = exit): ");
            string input = Console.ReadLine();
            if (input == '')
            {
                Console.WriteLine("The user exited the application");
                return;
            }
            string[] parts = input.Split(' ');
            MyStack myStack = new MyStack();

            foreach (string part in parts)
            {
                if (double.TryParse(part, out double number))
                {
                    Operand op = new Operand(number);
                    myStack.Push(op);
                }
                else
                {
                    Operator op = null;
                    if (part == "+") op = new SumOperator();
                    else if (part == "-") op = new SubtractOperator();
                    else if (part == "*") op = new MultiplyOperator();
                    else if (part == "/") op = new DivideOperator();
                    else if (part == "%") op = new ModulusOperator();
                    else
                    {
                        throw new InvalidTokenException("InvalidTokenException", part);
                    }
                    myStack.Push(op);
                }
            }
            Token calc_token = myStack.Pop();
            double result = calc_token.Evaluate(myStack);
            if (myStack.Count != -1)
            {
                throw new InvalidOperationException("InvalidOperationException");
            }
            Console.WriteLine(result);
        }
    }
}
