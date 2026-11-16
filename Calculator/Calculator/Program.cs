class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        int num1 = 5;

        int num2= 6;

        int result = calculator.Add(num1, num2);

        Console.WriteLine(result);
    }
}
