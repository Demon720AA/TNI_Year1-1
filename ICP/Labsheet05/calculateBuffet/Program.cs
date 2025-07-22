using System.Xml.Linq;

namespace calculateBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("Are you member [y/Y] : ");
            char member = char.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (member == 'y' || member == 'Y')
            {
                Console.Write("Input member name : ");
                name = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Write("How many customer\t: ");
            double customer = double.Parse(Console.ReadLine()), cusPrice = 299, cusTotal = cusPrice * customer;
            Console.Write("How many ice bucket\t: ");
            double ice = double.Parse(Console.ReadLine()), icePrice = 15, iceTotal = icePrice * ice;
            Console.Write("How many drink bottle\t: ");
            double drink = double.Parse(Console.ReadLine()), drinkPrice = 20, drinkTotal = drinkPrice * drink;
            double total = cusTotal + iceTotal + drinkTotal, vat = 0.03, totalVat = total + (total * vat);
            Console.WriteLine();

            if (member == 'y' || member == 'Y')
            {
                Console.WriteLine($"Welcome, {name}");
                totalVat -= totalVat * 0.1;
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Type\t\tUnit\t\tPrice\t\tTotal");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Cust\t\t{customer,4}\t\t{cusPrice,5}\t{cusTotal,13:N2}");
            Console.WriteLine($"Ice\t\t{ice,4}\t\t{icePrice,5}\t{iceTotal,13:N2}");
            Console.WriteLine($"Drink\t\t{drink,4}\t\t{drinkPrice,5}\t{drinkTotal,13:N2}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Total price\t\t\t\t{total,13:N2}");
            Console.WriteLine($"Add service charge\t\t\t{3,12}%");
            if (member == 'y' || member == 'Y')
            {
                Console.WriteLine($"Discount\t\t\t\t{10,12}%");
            }
            Console.WriteLine($"Total price\t\t\t\t{totalVat,13:N2}");

            Console.ReadKey();
        }
    }
}
