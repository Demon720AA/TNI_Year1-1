namespace Selection03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total1, discount = 5, total2;
            Console.Write("Input price per unit\t: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Input the number of unit : ");
            int unit = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            total1 = price * unit;
            if (total1 > 1500)
            {
                discount = 10;
            }
            total2 = total1 - (total1 * (discount / 100));
            Console.WriteLine($"Total price\t{total1,10:N2} baht.");
            Console.WriteLine($"Get discount\t{discount} %");
            Console.WriteLine($"Total price\t{total2,10:N2} baht.");

            Console.ReadKey();
        }
    }
}
