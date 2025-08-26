namespace Array04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many size of array : ");
            int size = int.Parse(Console.ReadLine());
            int[] num = new int[size];

            Console.WriteLine();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Input number {i+1} : ");
                num[i] = int.Parse(Console.ReadLine()) ;
            }
            Console.WriteLine($"\nThe first  element is {num[0]}");
            Console.WriteLine($"The middle element is {num[(num.Length/2)-1]}");
            Console.WriteLine($"The last   element is {num[num.Length-1]}");
            Console.ReadKey();
        }
    }
}
