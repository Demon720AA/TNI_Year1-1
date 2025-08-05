namespace Iteration03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many number to input : ");
            int num = int.Parse(Console.ReadLine()), inp,  even = 0, odd = 0;
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Input number {i} : ");
                inp = int.Parse(Console.ReadLine());
                if (inp % 2 == 0)
                {
                    ++even;
                }
                else
                {
                    ++odd;
                }
            }
            Console.WriteLine($"\nEven number have {even} from {num} number");
            Console.WriteLine($"Odd number have {odd} from {num} number");

            Console.ReadKey();
        }
    }
}
