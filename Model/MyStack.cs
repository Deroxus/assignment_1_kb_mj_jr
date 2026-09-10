namespace Calculator.Model
{
    public class MyStack
    {
        private int top;
        // set top and count to zero
        private Token[] internal_array;

        public myStack()
        {
            top = -1;
            internal_array = new Token[100];
        }
        public void Push(double d)
        {
            top += 1;
            internal_array[Top] = d;
        }

        public Token Pop()
        {
            Token return_value = internal_array[Top];
            top -= 1;
            return return_value;
        }
    }
}
