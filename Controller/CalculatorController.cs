using global::Calculator.Exceptions;
using global::Calculator.Model;
using global::Calculator.View;

namespace Calculator.Controller;

public class CalculatorController
{
    private string[] args;
    private RpnCalculator calculator;
    private ConsoleView view;

    public CalculatorController(string[] args)
    {
        this.args = args;
        calculator = new RpnCalculator();
        view = new ConsoleView();
    }
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
    private void RunConsoleMode()
    {
        while (true)
        {
            string input = view.GetInput();
            if (string.IsNullOrEmpty(input))
            {
                view.DisplayExitMessage();
                break;
            }
            try
            {
                double result = calculator.Calculate(input);
                view.DisplayResult(result);
            }
            catch (Exception exception)
            {
                view.DisplayError(exception.Message);
            }
        }
    }
    private void RunFileMode()
    {
        string source = args[0];
        string destination = args[1];
        string[] expressions = File.ReadAllLines(source);
        using StreamWriter writer = new StreamWriter(destination);
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
