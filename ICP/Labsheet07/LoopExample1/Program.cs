namespace LoopExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            //do
            //{
            //    Console.Write("Input a positive number : ");
            //    number = int.Parse(Console.ReadLine());
            //} while (number <= 0);

            Console.Write("Input a positive number : ");
            number = int.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.Write("Input a positive number, again : ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"You input number {number}");
            Console.ReadKey();
        }
    }
}
