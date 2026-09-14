namespace Calculator.Model;

// our base superclass for all tokens, inherited by all subclasses
// primarily operators and operands which in turn are inherited by specific operators 
public abstract class Token
{
    // using abstract and override keywords
    // abstract indicates the following subclasses must implement their own versions of the method
    // override indicates the method is overriding a method from the base class

    public abstract override string ToString();
    public abstract double Evaluate(MyStack stack);
}
