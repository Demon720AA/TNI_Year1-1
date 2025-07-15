namespace Selection02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Input your name\t: ");
            string name = Console.ReadLine();
            Console.Write("Input birth year : ");
            int birthYear = int.Parse(Console.ReadLine()), year = DateTime.Now.Year;

            age = year - birthYear;
            string result = (age < 18) ? "CANNOT VOTE" : "CAN VOTE";
            Console.WriteLine($"\nWelcome, {name} ({age} year old)");
            Console.WriteLine($"Result : {result}");
            Console.ReadKey();
        }
    }
}
