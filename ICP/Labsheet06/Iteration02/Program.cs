namespace Iteration02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many number of time to input : ");
            int num = int.Parse(Console.ReadLine()),sum = 0;
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Input number {i} : ");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nSum of all numbers from 1 to {num} is {sum}");
            Console.ReadKey();
        }
    }
}
