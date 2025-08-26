namespace Selection02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name\t : ");
            string name = Console.ReadLine();
            Console.Write("Input birth year : ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int age = DateTime.Now.Year - birthYear;
            Console.WriteLine($"Welcome, {name} ({age} year old)");
            Console.Write("Result : ");
            if (age >= 18)
            {
                Console.WriteLine("CAN VOTE");
            }
            else
            {
                Console.WriteLine("CAN VOTE");
            }
                Console.ReadKey();
        }
    }
}
