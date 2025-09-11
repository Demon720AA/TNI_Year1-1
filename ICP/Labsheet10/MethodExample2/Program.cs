namespace MethodExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("LENGTH OF ARRAY\t= ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            inputNumber(size);
            Console.ReadKey();
        }
        static void inputNumber(int size)
        {
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input number {i + 1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int count = countPositive(numbers);
            Console.WriteLine($"\nNUMBER OF POSITIVE = {count}\nNUMBER OF NEGATIVE AND ZERO = {size-count}");
        }
        static int countPositive(int[] numbers)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > 0) count++;
            }

            return count;
        }
    }
}
