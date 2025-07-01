namespace Variable03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 1000, num2 = 2010, num3 = 145000, num4 = 125.52;
            Console.WriteLine($"Number 1 = {num1:F3}");
            Console.WriteLine($"Number 2 = {num2:F3}");
            Console.WriteLine($"Number 3 = {num3:N1}");
            Console.WriteLine($"Number 4 = {num4:F0}");

            Console.ReadKey();
        }
    }
}
