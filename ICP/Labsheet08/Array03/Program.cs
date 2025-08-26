namespace Array03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Input number {i+1} : ");
                number[i] = int.Parse( Console.ReadLine() );
            }
            Console.ReadKey();
        }
    }
}
