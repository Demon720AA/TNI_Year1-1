namespace Variable07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productID = "BN-158", productName = "Notebook N-Series 7";
            int item = 3;
            float price = 17500.25f;

            Console.WriteLine($"PRODUCT ID      = {productID}");
            Console.WriteLine($"PRODUCT NAME    = {productName}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"ITEM\t{item,20}\titems.");
            Console.WriteLine($"PRICE\t{price,20:N}\tbaht.");
            price = price * item;
            Console.WriteLine($"TOTAL\t{price,20}\tbaht.");
            Console.WriteLine("---------------------------------------");
            price = price * 1.07f;
            Console.WriteLine($"VAT 7%\t{price,20:N}\tbaht.");

            Console.ReadKey();
        }
    }
}
