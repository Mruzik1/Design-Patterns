public class Add : AbstractOperation
{
    public Add() : base('+')
    {
        this.SetNextOperation(new Substract());
    }

    public override double Calculate(double value1, double value2, char operation)
    {
        if (charOperator == operation)
            return value1 + value2;

        return base.Calculate(value1, value2, operation);
    }
}