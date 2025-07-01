namespace Variable08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Pen", name2 = "Pencil", name3 = "Book";
            double price1 = 13.5, price2 = 210.3, price3 = 1090;
            int stock1 = 200, stock2 = 500, stock3 = 45;
            Console.WriteLine("Name\t\tStock\t\t\tPrice");
            Console.WriteLine("-----------------------------------------------");
            price1 = stock1 * price1;
            Console.WriteLine($"{name1,-8}\t{stock1,5}\t{price1,21:N}");
            price2 = stock2 * price2;
            Console.WriteLine($"{name2,-8}\t{stock2,5}\t{price2,21:N}");
            price3 = stock3 * price3;
            Console.WriteLine($"{name3,-8}\t{stock3,5}\t{price3,21:N}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Total\t\t{stock1+stock2+stock3,5}\t{price1+price2+price3,21:N}");

            Console.ReadKey();
        }
    }
}
