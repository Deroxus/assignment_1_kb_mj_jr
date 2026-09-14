namespace Calculator.Model;

// creating a custom stack class
public class MyStack
{
    // creating a private internal stack using "Stack<Token>" which is a built-in generic stack class in C#
    private Stack<Token> internalStack;

    public int Count
    {
        get { return internalStack.Count; }
    }

    // constructor to initialize the internal stack
    public MyStack()
    {
        internalStack = new Stack<Token>();
    }

    // using the "Stack" class allows us to use the built-in methods for push and pop
    public void Push(Token token)
    {
        internalStack.Push(token);
    }

    public Token Pop()
    {
        return internalStack.Pop();
    }
}
