using System.Net.Http.Headers;

namespace ExampleSelection03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input month (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Input year: ");
            int year = int.Parse(Console.ReadLine());
            bool leap = false;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        leap = true;
                    }
                }else
                {
                    leap = true;
                }
            }
            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: days = 31; break;

                case 4:
                case 6:
                case 9:
                case 11: days = 30; break;

                case 2: days = 28; if (leap)    
                    {
                        days = 29;
                    }
                        ; break;
                default: days = -1; break;
            }
            if (days == -1)
            {
                Console.WriteLine("Invalid month");
                return;
            }
            Console.WriteLine($"Month {month} Year {year} is {days}");



            Console.ReadKey();
        }
    }
}
