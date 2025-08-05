namespace IterationExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            int summary = 0;
            for (int i = 1; i <= num; i++)
            {
                summary += i;
            }
            Console.WriteLine($"\nSummary of 1 to {num} is {summary:N0}");
            Console.ReadKey();
        }
    }
}
