namespace Selection07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input employee's name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Input sale per month  : ");
            double sale = double.Parse(Console.ReadLine()), commission;


            if (sale <= 50000)
            {
                Console.WriteLine($"Sorry, {name}. You don't get any commission."); 
            } else if (sale <= 100000)
            {
                commission = (sale - 50000) * 0.10;
                Console.WriteLine($"\n{name} get commission {commission:N2} baht.");
            }
            else
            {
                commission = (sale - 100000) * 0.15 + 5000;
                Console.WriteLine($"\n{name} get commission {commission:N2} baht.");
            }

                Console.ReadKey();
        }
    }
}
