namespace Input10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input money : ");
            int money = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Type\t\tUnit\t\tValue");
            Console.WriteLine("-------------------------------------");
            int unit = money / 1000, value = unit * 1000;
            Console.WriteLine($"1000\t\t{unit,4}\t\t{value,5}");
            money -= unit * 1000;
            unit = money / 500;
            value = unit * 500;
            Console.WriteLine($"500\t\t{unit,4}\t\t{value,5}");
            money -= unit * 500;
            unit = money / 100;
            value = unit * 100;
            Console.WriteLine($"100\t\t{unit,4}\t\t{value,5}");
            money -= unit * 100;
            unit = money / 50;
            value = unit * 50;
            Console.WriteLine($"50\t\t{unit,4}\t\t{value,5}");
            money -= unit * 50;
            unit = money / 20;
            value = unit * 20;
            Console.WriteLine($"20\t\t{unit,4}\t\t{value,5}");
            money -= unit * 20;
            unit = money;
            value = money;
            Console.WriteLine($"Coin\t\t{unit,4}\t\t{value,5}");

            Console.ReadKey();
        }
    }
}
