namespace Input08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time parking (minute) : ");
            int totalMinute = int.Parse(Console.ReadLine()), hour = totalMinute / 60, minute = totalMinute % 60;
            double price = (hour * 30) + (minute * 0.5);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"\tTime : {hour} Hour {minute} Minute");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Total price = {price:N2} baht.");

            Console.ReadKey();
        }
    }
}
