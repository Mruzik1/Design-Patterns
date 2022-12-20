public class Calculator
{
    private char operation;
    private AbstractOperation primalOperation;
    private double number;

    public Calculator()
    {
        primalOperation = new Add();

        operation = '+';
        number = 0;
    }

    public double Calculate(double value)
    {
        number = primalOperation.Calculate(number, value, operation);
        return number;
    }

    public char SetOperation(char operation)
    {
        this.operation = operation;
        return operation;
    }

    public void Reset()
    {
        operation = '+';
        number = 0;
    }
}
