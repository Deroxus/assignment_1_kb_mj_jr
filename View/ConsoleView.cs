namespace Calculator.View;

// the main view class responsible for interacting with the user
public class ConsoleView
{
    // reading the input to send to the controller
    public string GetInput()
    {
        Console.Write("Enter an RPN expression <return> (empty string = exit): ");
        // using ?? "" to return an empty string if the user presses enter without typing anything
        return Console.ReadLine() ?? "";
    }

    public void DisplayResult(double result)
    {
        // printing the result to console with 2 decimals
        Console.WriteLine($"Result: {result.ToString("F2")}");
    }

    public void DisplayError(string message)
    {
        // showing error 
        Console.WriteLine(message);
    }

    public void DisplayExitMessage()
    {
        // if user doesn't type anything, this message will show
        Console.WriteLine("The user exited the application");
    }
}
