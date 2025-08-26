namespace Selection03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input price per unit\t  : ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Input the number of  unit : ");
            int unit = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            double totalPrice = price * unit;
            double discount = 5;
            if (totalPrice > 1500)
            {
                discount = 10;
            }
            Console.WriteLine($"Total price\t{totalPrice,10:N2} baht.");
            Console.WriteLine($"Get discount\t{discount,10} %");
            totalPrice -= totalPrice * (discount / 100);
            Console.WriteLine($"Total price\t{totalPrice,10:N2} baht.");
            Console.ReadKey();
        }
    }
}
