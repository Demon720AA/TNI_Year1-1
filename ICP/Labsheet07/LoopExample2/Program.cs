namespace LoopExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, age, now = DateTime.Now.Year;
            char again;
            do
            {
                do
                {
                    Console.Write("Input Birth Year (YYYY): ");
                    year = int.Parse(Console.ReadLine());

                } while (year < 2000 || year > now);
                age = now - year;
                Console.WriteLine($"Your age = {age}");
                Console.Write("Do you want to input again? : ");
                again = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (again == 'Y' || again == 'y');
            
            Console.WriteLine("BYE BYE...");

            Console.ReadKey();
        }
    }
}
