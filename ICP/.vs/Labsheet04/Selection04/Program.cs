namespace Selection04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "equal";
            Console.Write("Input the first  number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                result = "greater";
            } else if (num1 < num2)
            {
                result = "less";
            }
                Console.WriteLine($"\nThe first number ({num1}) is {result} than the second number ({num2})");

            Console.ReadKey();
        }
    }
}
