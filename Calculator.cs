namespace Calculator;

using global::Calculator.Controller;

public class Calculator
{
    static void Main(string[] args)
    {
        CalculatorController controller = new CalculatorController(args);
        controller.Run();
    }
}
