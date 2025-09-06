namespace MethodExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input base number : ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Input exponent number : ");
            int powNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double answerPower = Power(baseNum, powNum);
            Console.WriteLine($"The answer of {baseNum}^{powNum} is {answerPower}");
            Console.ReadKey();
        }
        static double Power(int baseNum, int powNum)
        {
            return Math.Pow(baseNum, powNum);
        }
    }
}
