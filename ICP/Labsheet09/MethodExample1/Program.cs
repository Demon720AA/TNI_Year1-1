namespace MethodExample1;

class Program
{
    static void Main(string[] args)
    {
        Power();
        Console.ReadKey();
    }

    static void Power()
    {
        Console.Write("Input base number : ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Input exponent number : ");
        int expNum = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nThe answer of {baseNum}^{expNum} is {Math.Pow(baseNum, expNum)}");
    }
}