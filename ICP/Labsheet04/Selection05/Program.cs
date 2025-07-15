namespace Selection05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("Input exercise score\t: ");
            double exercise = double.Parse(Console.ReadLine());
            Console.WriteLine("Input mid-term score\t: ");
            double midterm = double.Parse(Console.ReadLine());
            Console.WriteLine("Input final score\t: ");
            double final = double.Parse(Console.ReadLine());

            double total = exercise + midterm + final;
            if (total >= 80 && total <= 100)
            {
                grade = "A";
            } else if (total >= 75 && total < 80)
            {
                grade = "B+";
            } else if (total >= 70 && total < 75)
            {
                grade = "B";
            } else if (total >= 65 && total < 70)
            {
                grade = "C+";
            } else if (total >= 60 && total < 65)
            {
                grade = "C";
            } else if (total >= 55 && total < 60)
            {
                grade = "D+";
            } else if (total >= 50 && total < 55)
            {
                grade = "D";
            } else if (total >= 0 && total < 50)
            {
                grade = "F";
            }
            else
            {
                grade = "Error";
            }
            Console.WriteLine($"Your total score is {total}, get grade {grade}");
                Console.ReadKey();
        }
    }
}
