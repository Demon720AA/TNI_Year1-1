namespace Selection06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Press 'c' : Find a circle area");
            Console.WriteLine("Press 's' : Find a square area");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Input choice : ");
            char text = char.Parse(Console.ReadLine());
            double result;
            if (text == 'c' || text == 'C')
            {
                Console.WriteLine("\nYour choose \"Circle\"");
                Console.Write("Input radius : ");
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The circle area is {result}");
            } else if (text == 's' || text == 'S')
            {
                Console.WriteLine("\nYour choose \"Square\"");
                Console.WriteLine("Input length : ");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Input width  : ");
                double width = double.Parse(Console.ReadLine());
                result = length * width;
                Console.WriteLine($"The square is {result}");
            }

                Console.ReadKey();
        }
    }
}
