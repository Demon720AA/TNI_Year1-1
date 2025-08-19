namespace LoopExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num,sum = 0;
            //for (int i = 1; ; i++)
            //{
            //    Console.Write($"Input product {i} : ");
            //    num = double.Parse(Console.ReadLine());
            //    if (num <= 0)
            //    {
            //        break;
            //    }
            //    sum += num; 
            //}
            int count = 0;
            while (true)
            {
                Console.Write($"Input product {count} : ");
                num = double.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    break;
                }
                sum += num;
            }
            Console.WriteLine($"\nTotal price = {sum:N2}");
            Console.ReadKey();
        }
    }
}
