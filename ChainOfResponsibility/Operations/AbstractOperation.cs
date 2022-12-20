public abstract class AbstractOperation : IOperation
{
    private IOperation nextOperation;
    protected char charOperator;

    public AbstractOperation(char charOperator)
    {
        this.charOperator = charOperator;
    }

    public void SetNextOperation(IOperation operation)
    {
        nextOperation = operation;
    }

    public virtual double Calculate(double value1, double value2, char operation)
    {
        if (nextOperation is null)
            return value1;
        return nextOperation.Calculate(value1, value2, operation);        
    }
}