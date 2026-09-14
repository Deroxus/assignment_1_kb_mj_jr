namespace Calculator.Model;

public class MultiplyOperator : Operator
{
    // creating specific implementation of the caluclate method for mutliplication
    public override double Calculate(double leftOperand, double rightOperand)
    {
        return leftOperand * rightOperand;
    }
    public override string ToString()
    {
        return "*";
    }
}
