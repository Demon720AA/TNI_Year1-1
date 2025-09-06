namespace Method05_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTitle();
            int num, count = 0, sum = 0, max = 0, min = 0;
            double mean;
            bool stop;
            do
            {
                Console.Write("Input integer (9999 to stop): ");
                num = int.Parse(Console.ReadLine());
                stop = IsStop(num, 9999);
                if (stop)
                {
                    break;
                }
                if (count == 0)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }else if (num < min)
                {
                    min = num;
                }
                sum += num;
                count++;
                Console.WriteLine(count);
            } while (true);
            Console.WriteLine();
            mean = ComputeMean(sum, count);
            PrintSummary(count, sum, mean, min, max);
            Console.ReadKey();
        }
        static void PrintTitle()
        {
            Console.WriteLine("========== Statistice ==========");
        }
        static bool IsStop(int value, int stopValue)
        {
            return value == stopValue;
        }
        static double ComputeMean(long sum, int count)
        {
            return sum / (double)count;
        }
        static void PrintSummary(int count, long sum, double mean, int min, int max)
        {
            Console.WriteLine($"Count\t= {c}");
            Console.WriteLine($"Sum\t= {sum}");
            Console.WriteLine($"Mean\t= {mean:F3}");
            Console.WriteLine($"Min\t= {min}");
            Console.WriteLine($"Max\t= {max}");
        }
    }
}
