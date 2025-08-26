namespace Array02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Input number {i+1} : ");
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nList of even number = ");
            foreach (int i in number)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\nList of odd number = ");
            foreach (int i in number)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadKey();
        }
    }
}
