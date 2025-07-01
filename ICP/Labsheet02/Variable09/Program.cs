namespace Variable09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customer = 7, bucket = 5, bottle = 8;
            float buffet = 299, ice = 15, drink = 25;
            double customerTotal = customer * buffet, bucketTotal = bucket * ice, bottleTotal = bottle * drink, lastTotal = customerTotal + bucketTotal + bottleTotal;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Type\t\tUnit\t\tPrice\t\tTotal");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Customer\t{customer,4}\t\t{buffet,5}\t{customerTotal,13:N}");
            Console.WriteLine($"Ice\t\t{bucket,4}\t\t{ice,5}\t{bucketTotal,13:N}");
            Console.WriteLine($"Drink\t\t{bottle,4}\t\t{drink,5}\t{bottleTotal,13:N}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Total price (No service charge)\t\t{lastTotal,13:N}");

            Console.ReadKey();
        }
    }
}
