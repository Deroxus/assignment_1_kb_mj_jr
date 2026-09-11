namespace Calculator.Model;

public class MyStack
{
    private int top = -1;
    public int Count
    {
        get { return top + 1; }
    }

    // set top and count to zero
    private Token[] internal_array;

    public MyStack()
    {
        top = -1;
        internal_array = new Token[100];
    }
    public void Push(Token d)
    {
        top += 1;
        internal_array[top] = d;
    }

    public Token Pop()
    {
        Token return_value = internal_array[top];
        top -= 1;
        return return_value;
    }
}
