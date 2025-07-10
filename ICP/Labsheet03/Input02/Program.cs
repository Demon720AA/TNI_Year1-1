namespace Input02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input student id\t: ");
            string studentId = Console.ReadLine();
            Console.Write("Input student name\t: ");
            string studentName = Console.ReadLine();
            Console.Write("Input mid-term score\t: ");
            int midtermScore = int.Parse(Console.ReadLine());
            Console.Write("Input final score\t: ");
            int finalScore = int.Parse(Console.ReadLine());
            int total = midtermScore + finalScore;
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"STUDENT   : {studentName} ({studentId})\nGET SCORE : {total} ({midtermScore} + {finalScore})");

            Console.ReadKey();
        }
    }
}
