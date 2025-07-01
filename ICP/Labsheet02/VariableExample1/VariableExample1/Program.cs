namespace VariableExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productId = "NB-001";
            string productName = "Notebook Series";
            int productPrice = 25000;
            double vat = productPrice * 7 / 100;
            double totalPrice = productPrice + vat;

            Console.WriteLine($"PRODUCT     : {productId} ({productName})");
            Console.WriteLine($"PRICE       : {productPrice,11:n}\tBaht.");
            Console.WriteLine($"ADD VAT     : {vat,11:n}\tBaht.");
            Console.WriteLine($"TOTAL PRICE : {totalPrice,11:n}\tBaht.");
            Console.ReadKey();
        }
    }
}
