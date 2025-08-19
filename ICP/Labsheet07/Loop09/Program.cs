namespace Loop09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input total price : ");
            double price = double.Parse(Console.ReadLine()), total;
            Console.Write("Is customer a member? (Y/N) : ");
            char member = char.Parse(Console.ReadLine());
            if (member == 'Y' || member == 'y')
            {
                Console.Write("Input member type (P or R) : ");
                char type = char.Parse(Console.ReadLine());
                total = (type == 'P' || type == 'p') ? price - (price * 0.10) : (type == 'R' || type == 'r')?price - (price * 0.05): price;
            }else
            {
                total = price;
            }
                Console.WriteLine($"Total price = {total:N2} Baht.");
            Console.ReadKey();
        }
    }
}
