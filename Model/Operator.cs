namespace Calculator.Model
{
    public abstract class Operator : Token
    {
        public abstract double Calculate(double leftOperand, double rightOperand);
    }
}
