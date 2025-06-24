using System;

namespace Display05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x = 5, y = 6, z = 7");
            Console.WriteLine("(x + y) * z = " + ((5 + 6) * 7));
            Console.Write("(x * y) + (y * z) = " + ((5 * 6) + (6 * 7)));

            Console.ReadKey();
        }
    }
}
