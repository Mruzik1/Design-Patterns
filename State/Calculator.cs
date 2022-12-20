public class Calculator
{
    private char operation;
    private double number;
    IOperation currentState;

    public Calculator()
    {
        currentState = new Add();

        operation = '+';
        number = 0;
    }

    public double Calculate(double value)
    {
        switch (operation)
        {
            case '+':
                currentState = new Add();
                break;
            case '-':
                currentState = new Substract();
                break;
            case '*':
                currentState = new Multiply();
                break;
            case '/':
                currentState = new Divide();
                break;
            default:
                return number;
        }

        number = currentState.Calculate(number, value);
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
