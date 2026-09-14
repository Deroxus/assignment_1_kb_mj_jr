namespace Calculator.Model;

public class MyStack
{
    private readonly Stack<Token> internalStack;

    public int Count
    {
        get { return internalStack.Count; }
    }

    public MyStack()
    {
        internalStack = new Stack<Token>();
    }

    public void Push(Token token)
    {
        internalStack.Push(token);
    }

    public Token Pop()
    {
        return internalStack.Pop();
    }
}
