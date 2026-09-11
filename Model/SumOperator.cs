namespace Calculator.Model
{
    public class SumOperator : Operator
    {
        public override double Calculate(double leftOperand, double rightOperand)
        {
            return leftOperand + rightOperand;
        }
        public override string ToString()
        {
            return "+";
        }
    }
}
