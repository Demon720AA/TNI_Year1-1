using System.Numerics;

namespace Labsheet09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Power();
            Console.ReadKey();
        }
        static void Power()
        {
            Console.Write("Input base number : ");
            double baseNumber = double.Parse(Console.ReadLine());
            Console.Write("Input exponent number : ");
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine();
            double answerPower = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"The answer of {baseNumber} ^ {exponent} is {answerPower}");
        }
    }
}
