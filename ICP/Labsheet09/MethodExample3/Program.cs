namespace MethodExample3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\t\tTNI Delivery");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Press 1 : Tokoyaki\t180 Baht.\nPress 2 : Udon\t\t100 Baht.\nPtess 3 : Taiyaki\t250 Baht.\nPress 4 : Calculate");
        Console.WriteLine("---------------------------------------------");
        double sum = 0;
        while (true)
        {
            Console.Write("Input the number of menu : ");
            int menuNum = int.Parse(Console.ReadLine());
            if (menuNum == 1) sum += 180;
            else if (menuNum == 2) sum += 100;
            else if (menuNum == 3) sum += 250;
            else if (menuNum == 4)break;
            else Console.WriteLine("Wrong input!");
        }
        Console.WriteLine($"\nThe total price is {sum:N}Baht.");
        Console.WriteLine($"Current time is {DateTime.Now:HH:mm}");
        Console.WriteLine($"Orders will be delivered at {DateTime.Now.AddMinutes(30):HH:mm}");
        Console.ReadKey();
    }
}