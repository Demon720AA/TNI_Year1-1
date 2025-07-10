namespace Input06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input employee salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");
            double empSocail = salary * 0.03, empTax = salary * 0.04, getSalary = salary - empSocail - empTax;
            Console.WriteLine($"Employee salary\t\t{salary,10:N2} baht.");
            Console.WriteLine($"Social Security\t\t{empSocail,10:N2} baht.");
            Console.WriteLine($"Tax\t\t\t{empTax,10:N2} baht.");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Get salary\t\t{getSalary,10:N2} baht.");

            Console.ReadKey();
        }
    }
}
