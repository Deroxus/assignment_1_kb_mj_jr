namespace Calculator.View;

public class ConsoleView
{
    public string GetInput()
    {
        Console.Write(
            "Enter an RPN expression <return> (empty string = exit): "
        );

        return Console.ReadLine() ?? "";
    }

    public void DisplayResult(double result)
    {

        // Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Result: {result.ToString("F2")}");
    }

    public void DisplayError(string message)
    {
        Console.WriteLine(message);
    }

    public void DisplayExitMessage()
    {
        Console.WriteLine("The user exited the application");
    }
}
