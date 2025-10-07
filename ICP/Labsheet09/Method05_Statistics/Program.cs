namespace Method05_Statistics;

class Program
{
    static void Main(string[] args)
    {
        PrintTiltle();
        int value, sum = 0, min = 0, max = 0, count = 0;
        while (true)
        {
            Console.Write("Input integer (9999 to stop): ");
            value = int.Parse(Console.ReadLine());
            if (IsStop(value, 9999)) break;
            if (count++ == 0)
            {
                min = value;
                max = value;
            }
            if (value > max) max = value;
            else if (value < min) min = value;
            sum += value;
        }

        double mean = ComputeMean(sum, count);
        PrintSummary(count, sum, mean, min, max);
        Console.ReadKey();
    }

    static void PrintTiltle()
    {
        Console.WriteLine("=== Statistics ===");
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
        Console.WriteLine($"\nCount\t= {count}\nSum\t= {sum}\nMean\t= {mean:F3}\nMin\t = {min}\nMax\t = {max}");
    }
}