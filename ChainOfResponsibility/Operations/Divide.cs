public class Divide : AbstractOperation
{
    public Divide() : base('/') {}

    public override double Calculate(double value1, double value2, char operation)
    {
        if (charOperator == operation)
            return value1 / value2;

        return base.Calculate(value1, value2, operation);
    }
}