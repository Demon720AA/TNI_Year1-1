namespace Method01_CalculateFactorial;

class Program
{
    public static void Main() {
        Console.Write("Input a number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        // call method power and factorial
        Power(number);
        Factorial(number);
        // // Display results in the Main() method
        // Console.WriteLine($"The answer of {number}^2 = {powerResult}");
        // Console.WriteLine($"The answer of {number}! = { factorialResult}");
        Console.ReadKey();
    }

    public static void Power(int number)
    {
        Console.WriteLine($"The answer of {number}^2 = {Math.Pow(number, 2)}");
    }

    public static void Factorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"The answer of {number}! = {factorial}");
    }
}