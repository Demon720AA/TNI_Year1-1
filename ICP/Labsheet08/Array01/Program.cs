namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Input number {i + 1} : ");
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nElements in array (erverse) : ");
            for (int i = 0;i < number.Length; i++)
            {
                Console.Write(number[number.Length-i-1]+ " ");
            }
            Console.ReadKey();
        }
    }
}
