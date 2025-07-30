using System.Security.Cryptography;

namespace Quize1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input user type (Adult / Student / Child) : ");
            string userType = Console.ReadLine();
            Console.Write("Input time (Morning / Afternoon / Evening) : ");
            string time = Console.ReadLine();
            int price;
            switch (userType)
            {
                case "Adult":
                case "ADULT":
                case "adult":
                    price = 0;
                    if (time == "Morning" || time == "MORNING" || time == "morning")
                    {
                        price = 120;
                    }else if(time == "Afternoon" || time == "AFTERNOON" || time == "afternoon")
                    {
                        price = 150;
                    }else if (time == "Evening" || time == "EVENING" || time == "evening")
                    {
                        price = 180;
                    }
                    else
                    {
                        Console.WriteLine("invalid time");
                        return;
                    }
                    break;
                case "Student":
                case "STUDENT":
                case "student":
                    price = 0;
                    if (time == "Morning" || time == "MORNING" || time == "morning")
                    {
                        price = 100;
                    }
                    else if (time == "Afternoon" || time == "AFTERNOON" || time == "afternoon")
                    {
                        price = 120;
                    }
                    else if (time == "Evening" || time == "EVENING" || time == "evening")
                    {
                        price = 150;
                    }
                    else
                    {
                        Console.WriteLine("invalid time");
                        return;
                    }
                    break;
                case "Child":
                case "CHILD":
                case "child":
                    price = 0;
                    if (time == "Morning" || time == "MORNING" || time == "morning")
                    {
                        price = 80;
                    }
                    else if (time == "Afternoon" || time == "AFTERNOON" || time == "afternoon")
                    {
                        price = 100;
                    }
                    else if (time == "Evening" || time == "EVENING" || time == "evening")
                    {
                        price = 120;
                    }
                    else
                    {
                        Console.WriteLine("invalid time");
                        return;
                    }
                    break;
                default:
                    price = -1;
                    Console.WriteLine("invalid user type");
                    break;
            }
            Console.Write($"Price : {price}"+ ((userType == "Student" || userType == "STUDENT" || userType == "student" || userType == "Child" || userType == "CHILD" || userType == "child") 
                && (time == "Morning" || time == "MORNING" || time == "morning") ? "(discount)" : ""));
            Console.ReadKey();
        }
    }
}
