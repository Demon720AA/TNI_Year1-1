namespace Labsheet08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[7];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Input number index {i+1} : ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Elements in array are ");
            for (int i = 0;i < num.Length;i++)
            {
                Console.Write(num[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
