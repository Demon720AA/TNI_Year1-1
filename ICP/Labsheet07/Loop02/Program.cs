namespace Loop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Input number {i} : ");
                num = int.Parse(Console.ReadLine());
                while (num <= 0)
                {

                    Console.Write($"Input number {i}, again : ");
                    num = int.Parse(Console.ReadLine());
                }
                sum += num;
            }
            double avg = sum / 5;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"sum of 5 numbers is {sum}");
            Console.WriteLine($"Average is {avg:F2}");
            Console.ReadKey();
        }
    }
}
