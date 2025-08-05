namespace IterationExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (num < 0)
            {
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i*num}");
            }

            Console.ReadKey();
        }
    }
}
