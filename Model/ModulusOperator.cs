using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;
namespace Calculator.Model
{
    public class ModulusOperator : Operator
    {
        public override double Calculate(double leftOperand, double rightOperand)
        {
            if (rightOperand == 0)
            {
                throw new DivideByZeroException("Division error", leftOperand.ToString() + "/" + rightOperand.ToString);
            }
            return leftOperand % rightOperand;
        }
    }
}
