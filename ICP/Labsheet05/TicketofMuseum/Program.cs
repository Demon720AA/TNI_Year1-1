namespace TicketofMuseum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input birth year  : ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Are you member    : ");
            char member = char.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            int thisYear = DateTime.Today.Year, age = thisYear - birthYear;
            double price, discount = 0;
            price = (age >= 18) ? 150 : 100;
            // if (age >= 18)
            // {
            //     price = 150;
            // }
            // else
            // {
            //     price = 100;
            // }
            discount = (member == 'Y' || member == 'y') ? 5 : 0;
            Console.Write($"" + (member == 'Y' || member == 'y') ?"Get discount\t{discount,10} %" : "");
            //(member == 'Y' || member == 'y') ? Console.WriteLine($"Get discount\t{discount,10} %") : Console.Write("");  
            //if (member == 'Y' || member == 'y')
            //{
            //    discount = 5;
            //    Console.WriteLine($"Get discount\t{discount,10} %");
            //}
            price -= (price * (discount / 100));
            Console.WriteLine($"Total price\t{price,10:N2} baht.");
            Console.ReadKey();
        }
    }
}
