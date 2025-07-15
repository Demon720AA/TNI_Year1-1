namespace SelectionExample01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buffetPrice = 299, result, discount = 0, total;
            Console.WriteLine("Input the number of customer : ");
            int cus = int.Parse(Console.ReadLine());
            result = cus * buffetPrice;
            Console.WriteLine($"Amount to be paid {result:N2} baht.");
            if (cus >= 7)
            {
                discount = (result * 0.10);
                Console.WriteLine($"Discount : {discount}");
            }
            total = result - discount;
            Console.WriteLine($"Total : {total}");

            Console.ReadKey();
        }
    }
}
