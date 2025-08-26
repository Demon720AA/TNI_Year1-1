namespace Selection06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Press 'c' : Find a circle area");
            Console.WriteLine("Press 's' : Find a square area");
            Console.WriteLine("--------------------------------------");
            Console.Write("Input choice : ");
            char text = char.Parse(Console.ReadLine());
            if (text == 'c' || text == 'C')
            {
                Console.WriteLine($"\nYou choose : \"Circle\"");
                Console.Write("Input radius : ");
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI *  Math.Pow(radius, 2);
                Console.WriteLine($"\nThe circle area is {result:N2}");
            } else if (text == 's' || text == 'S')
            {
                Console.WriteLine($"\nYou choose : \"Square\"");
                Console.Write("Input length : ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Input width  : ");
                double width = double.Parse(Console.ReadLine());
                result = width * length;
                Console.WriteLine($"\nThe square area is {result:N2}");
            }
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
        }
    }
}
