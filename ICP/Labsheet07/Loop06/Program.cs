using System;

namespace Loop06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price,sum=0;
            int unit;
            char check;

            do
            {
                Console.Write("Input price per unit : ");
                price = double.Parse(Console.ReadLine());
                Console.Write("Input number of unit : ");
                unit = int.Parse(Console.ReadLine());
                sum += price * unit;
                Console.WriteLine($"\nTotal price is {price*unit:N2} baht.");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.Write("Do you have other products? : ");
                check = char.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------");
            } while (check == 'Y' || check == 'y');

            Console.WriteLine($"\nTotal price of all product is {sum:N2} baht.");
            Console.ReadKey();
        }
    }
}