namespace Input01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input number2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input number3 : ");
            int num3 = int.Parse(Console.ReadLine());
            int summary = num1 + num2 + num3;
            double average = (double)summary / 3;
            Console.WriteLine();
            Console.WriteLine($"Summary of {num1}, {num2} and {num3} is {summary}");
            Console.WriteLine($"Average is {average:F2}");

            Console.ReadKey();
        }
    }
}
