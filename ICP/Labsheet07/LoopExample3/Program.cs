namespace LoopExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            do
            {
                Console.Write("Input a number : ");
                num = int.Parse(Console.ReadLine());
            } while (num <= 1);
            for (int i=1;i <= num; i++)
            {
                sum += i;
            }
            Console.Write($"\nSum of 1 to {num} = {sum}");

            Console.ReadKey();
        }
    }
}
