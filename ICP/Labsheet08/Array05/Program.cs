namespace Array05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many product list in stock : ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] stock = new int[size];

            for (int i = 0;i< stock.Length; i++)
            {
                Console.Write($"How many item of product {i+1} : ");
                stock[i] = int.Parse(Console.ReadLine());
                while (stock[i] < 0)
                {
                    Console.Write($"Input item of product {i+1}, again : ");
                    stock[i] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i=0; i < stock.Length; i++)
            {
                Console.Write($"Product {i+1} has {stock[i]} item");
                Console.WriteLine((stock[i] == 0) ? "(OUT OF STOCK)" : (stock[i] <= 5) ? "(LOW)" : "");
            }
            Console.ReadKey();
        }
    }
}
