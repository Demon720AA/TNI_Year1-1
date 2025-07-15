namespace Selection04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "equal";
            Console.Write("Input the first  number : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input the second number : ");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                result = "greater";
            } else if (num1 < num2)
            {
                result = "less";
            }
            Console.WriteLine($"The first number ({num1}) is {result} to the second number {num2}");
                Console.ReadKey();
        }
    }
}
