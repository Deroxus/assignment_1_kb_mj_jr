namespace Calculator.Model;

public class Operand : Token
{
    // only using get accessor since the value shouldn't be changed after the object is created
    private double value;
    public double Value
    {
        get { return value; }
    }

    // operand token only allows doubles
    public Operand(double number)
    {
        value = number;
    }

    public override string ToString()
    {
        return value.ToString();
    }

    // recursive method used primarily in Operator class
    public override double Evaluate(MyStack stack)
    {
        return value;
    }
}
