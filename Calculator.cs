namespace Calculator;

using global::Calculator.Controller;

public class Calculator
{
    // the "main" method that is the entry point of the program
    static void Main(string[] args)
    {
        // passing the command line arguments to the controller
        CalculatorController controller = new CalculatorController(args);
        controller.Run();
    }
}
