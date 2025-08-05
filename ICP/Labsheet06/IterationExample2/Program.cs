namespace IterationExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
