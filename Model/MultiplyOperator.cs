namespace Calculator.Model;

public class MultiplyOperator : Operator
{
    public override double Calculate(double leftOperand, double rightOperand)
    {
        return leftOperand * rightOperand;
    }
    public override string ToString()
    {
        return "*";
    }
}
