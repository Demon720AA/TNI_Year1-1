namespace SelectionExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double buffetbyPerson = 299;
            double totalPrice = 0;
            double discount = 0;
            
            Console.Write("Enter number of customers : ");
            int numberofCust = int.Parse(Console.ReadLine());
            totalPrice = buffetbyPerson * numberofCust;

            Console.WriteLine($"\nTotal Price : {totalPrice:N2} baht.");
            if (numberofCust >= 7)
            {
                discount = totalPrice * 0.10;
            }
            Console.WriteLine($"Discount : {discount:N2}");
            if (numberofCust >= 7)
            {
                totalPrice -= discount;
            }
            Console.WriteLine($"Amount to be paid : {totalPrice:N2}");

            Console.ReadKey();
        }
    }
}
