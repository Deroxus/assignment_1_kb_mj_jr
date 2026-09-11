namespace Calculator;

using global::Calculator.Controller;

public class Calculator
{
    static void Main(string[] args)
    {
        if (args.Length != 0 && args.Length != 2)
        {
            Console.WriteLine("Syntax Error");
            return;
        }
        CalculatorController controller = new CalculatorController();
        controller.Run(args);
    }
}
