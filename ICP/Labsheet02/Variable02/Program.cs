namespace Variable02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 252, num2 = 147, num3 = 368, total =  num1 + num2 + num3;
            double average = (num1 + num2 + num3) / 3.0;
            Console.WriteLine($"Number 1 = {num1}");
            Console.WriteLine($"Number 2 = {num2}");
            Console.WriteLine($"Number 3 = {num3}");
            Console.WriteLine($"Summary of {num1}, {num2} and {num3} is {total}");
            Console.WriteLine($"Average is {average:F2}");

            Console.ReadKey();
        }
    }
}
