Calculator calculator = new Calculator();

Console.WriteLine(calculator.Calculate(5));
calculator.SetOperation('*');
Console.WriteLine(calculator.Calculate(3));
calculator.SetOperation('-');
Console.WriteLine(calculator.Calculate(10));
calculator.SetOperation('/');
Console.WriteLine(calculator.Calculate(2));