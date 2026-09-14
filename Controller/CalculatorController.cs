// Using "global::" prefix for namespaces to avoid conflicts with our own namespaces.
using global::Calculator.Exceptions;
using global::Calculator.Model;
using global::Calculator.View;

namespace Calculator.Controller;

// The controller class is responsible for passing the user input from Calculator.cs to the RPNCalculator file
// and then passing the result back to the ConsoleView to be displayed to the user.
public class CalculatorController
{
    // the arguments from the command line, or the input output files
    private string[] args;
    // the calculator object that will perform the calculations
    private RpnCalculator calculator;
    // the view object that will display the results to the user
    private ConsoleView view;

    // the constructor for the calculator controller which takes the arguments
    // creates a new RPNCalculator object, and creates a new ConsoleView object.
    public CalculatorController(string[] args)
    {
        this.args = args;
        calculator = new RpnCalculator();
        view = new ConsoleView();
    }
    // The Run method which is responsible for determining whether to run in console mode (no other arguments)
    // or file mode (source and destination), otherwise display error
    public void Run()
    {
        if (args.Length == 0)
        {
            RunConsoleMode();
        }
        else if (args.Length == 2)
        {
            RunFileMode();
        }
        else
        {
            view.DisplayError
            ("Syntax: Calculator [source destination]");
        }
    }

    // No arguments, only "dotnet run"
    private void RunConsoleMode()
    {
        while (true)
        {
            // GetInput method from ConsoleView class to get user input
            string input = view.GetInput();
            if (string.IsNullOrEmpty(input))
            {
                // DisplayExitMessage method from ConsoleView class to display exit message
                view.DisplayExitMessage();
                break;
            }
            try
            {
                // try to calculate, if it fails, catch the exception and display the error message
                double result = calculator.Calculate(input);
                view.DisplayResult(result);
            }
            catch (Exception exception)
            {
                view.DisplayError(exception.Message);
            }
        }
    }

    // two arguments, source and destination files
    private void RunFileMode()
    {
        // source is input file
        string source = args[0];
        // destination is output file
        string destination = args[1];
        // Read all lines from the source file
        string[] expressions = File.ReadAllLines(source);
        // using C# built in StreamWriter to write to the destination file
        using StreamWriter writer = new StreamWriter(destination);
        // loop through each expression in the source file and calculate the result
        foreach (string expression in expressions)
        {
            try
            {
                double result = calculator.Calculate(expression);
                writer.WriteLine(result.ToString("F2"));
            }
            catch (Exception exception)
            {
                writer.WriteLine(exception.Message);
            }
        }
    }
}
