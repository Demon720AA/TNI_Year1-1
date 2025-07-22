namespace carParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time (minute) : ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            int hour = time / 60, minute = time % 60;
            Console.WriteLine($"Time = {hour} hour {minute} minute");
            if (minute >= 15)
            {
                minute = 0;
                Console.WriteLine($"New  = {++hour} hour {minute} minute");
            }
            Console.WriteLine("-------------------------------------------------");
            if (hour > 3 || hour == 3 && minute > 0)
            {
                double paid = ((hour - 3) * 40) + (minute * 0.5);
                Console.WriteLine($"Amount to be paid {paid:N2} baht.");
            }
            else
            {
                Console.WriteLine("Park Free!!");
            }

                Console.ReadKey();
        }
    }
}
