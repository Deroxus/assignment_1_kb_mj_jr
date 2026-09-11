namespace Calculator.Model;

public abstract class Token
{
    public abstract override string ToString();
    public abstract double Evaluate(MyStack stack);
}
