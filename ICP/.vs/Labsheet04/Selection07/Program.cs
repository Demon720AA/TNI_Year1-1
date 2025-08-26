namespace Selection07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input employee's name : ");
            string name = Console.ReadLine();
            Console.Write("Input sale per month  : ");
            double sale = double.Parse(Console.ReadLine());
            double commission = 0;
            if (sale <= 50000)
            {
                Console.WriteLine($"\nSorry, {name}, You don't get any commission.");
            } else if (sale > 50000 && sale < 100000)
            {
                commission = (sale - 50000) * 0.10;
                Console.WriteLine($"\n{name} get commission {commission:N2} baht.");
            } else
            {
                commission = (sale - 100000) * 0.15 + 5000;
                Console.WriteLine($"\n{name} get commission {commission:N2} baht.");
            }
                Console.ReadKey();
        }
    }
}
