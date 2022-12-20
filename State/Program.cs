Calculator calculator = new Calculator();
string[] tasks = File.ReadAllLines("./numbers.txt");

foreach (string task in tasks)
{
    string[] splittedTask = task.Split(' ');
    double value1 = double.Parse(splittedTask[0]);
    double value2 = double.Parse(splittedTask[2]);
    char operatorChar = splittedTask[1][0];

    calculator.Calculate(value1);
    calculator.SetOperation(operatorChar);
    Console.WriteLine(calculator.Calculate(value2));

    calculator.Reset();
}