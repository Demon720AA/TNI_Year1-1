namespace MethodExample2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input  base number : ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("Input exponent number : ");
        int powNum = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nThe answer of {baseNum}^{powNum} is {Power(baseNum, powNum)}");
        Console.ReadKey();
    }

    static double Power(int baseNum, int powNum)
    {
        return Math.Pow(baseNum, powNum);
    }
}