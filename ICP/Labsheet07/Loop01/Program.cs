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
            for (int i = 0; i <= number; i++)
            {
            if (number %  2 == 0)
            {
                
            } else
                {
                    Console.WriteLine("I Love C#");
                }
            }
            Console.ReadKey();
        }
    }
}
