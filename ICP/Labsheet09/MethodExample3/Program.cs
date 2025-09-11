namespace MethodExample3
{
    internal class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            DisplayHeader();
            double totalPrice = CalculateTotalPrice();
            DisplaySummary(totalPrice);
            Console.ReadKey();
        }
        static void DisplayHeader()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\t\tTNI Delivery");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Press 1 : Tokoyaki\t180 Baht.\nPress 2 : Udon\t\t100 Baht.\nPress 3 : Taiyaki\t250 Baht.\nPress 4 : Calculate");
            Console.WriteLine("-------------------------------------------------");

        }
        static double CalculateTotalPrice()
        {
            const double TOKOYAKI = 180, UDON = 100, TAIYAKI = 250;
            int num;
            bool keepGoing = true;
            double totalPrice = 0;
            do
            {
                Console.Write("Input the number of menu : ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1: 
                        totalPrice += TOKOYAKI;
                        break;
                    case 2:
                        totalPrice += UDON;
                        break;
                    case 3:
                        totalPrice += TAIYAKI;
                        break;
                    case 4:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid menu.");
                        break;
                }
            } while (keepGoing);

            Console.WriteLine();
            return totalPrice;
        }
        static void DisplaySummary(double total)
        {
            Console.WriteLine($"Total price  is {total:N0} Baht.");
            Console.WriteLine($"Current time is {DateTime.Now:HH:mm}");
            Console.WriteLine($"Current time is {DateTime.Now.AddMinutes(30):HH:mm}");
        }
    }
}
