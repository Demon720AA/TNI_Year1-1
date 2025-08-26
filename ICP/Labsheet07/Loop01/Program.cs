namespace Loop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number greater than 1 : ");
            int number = int.Parse(Console.ReadLine());
            while (number <= 1)
            {
                Console.Write("Error!! Input a number, again : ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            if (number %  2 == 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{i} x {number} = {i*number}");
                }
            } else
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("I Love C#");
                }
            }
            Console.ReadKey();
        }
    }
}
