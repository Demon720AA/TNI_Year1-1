namespace dispalyTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input hour\t: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Input minute\t: ");
            int minute = int.Parse(Console.ReadLine());
            Console.Write("Input second\t: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine();
                
            Console.Write($"Time is ");
            if (hour < 10)
            {
                Console.Write("0"); 
            }
            Console.Write($"{hour}:");
            if (minute < 10)
            {
                Console.Write("0");
            }
            Console.Write($"{minute}:");
            if (second < 10)
            {
                Console.Write("0");
            }
            Console.Write($"{second}");

            Console.ReadKey();
        }
    }
}
