namespace Iteration01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Input choice 0 or 1 : ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice > 1 || choice < 0)
            {
                return;
            }
            for (int i = ((choice+3)%2)+1; i <= num; i += 2)
            {
                Console.Write((i)+" ");
            }
            Console.ReadKey();
        }
    }
}
