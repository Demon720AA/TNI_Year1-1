namespace Iteration05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Right-Triangle base : ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Input picture number : ");
            int picNum = int.Parse(Console.ReadLine());
            switch (picNum)
            {
                case 1:
                    for (int i = 1; i <= baseNum; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = baseNum; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = baseNum; i >= 1; i--)
                    {
                        for (int j = baseNum - i; j >= 1; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = i; k >= 1; k--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    for (int i = 1; i <= baseNum; i++)
                    {
                        for (int j = baseNum - i; j >= 1; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = i; k >= 1; k--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

                Console.ReadKey();
        }
    }
}
