namespace Controller.Model
{
    public class Operand : Token
    {
        private double value;
        public double Value
        {
            get { return value; }
        }

        public Operand(double number)
        {
            value = number;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
