namespace Iteration04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many student in classroom : ");
            int student = int.Parse(Console.ReadLine()), score, pass = 0, fail = 0;
            double sum = 0;
            Console.WriteLine();
            for (int i = 1; i <= student; i++)
            {
                Console.Write($"Input score of student {i} : ");
                score = int.Parse(Console.ReadLine());
                if (score >= 50)
                {
                    ++pass;
                }
                else
                {
                    ++fail;
                }
                sum += score;
            }
            Console.WriteLine($"\nSum of all score is {sum}");
            Console.WriteLine($"Average of all score is {sum/student:F2}");
            Console.WriteLine($"The number of PASS student is {pass}");
            Console.WriteLine($"The number of FAIL student is {fail}");

            Console.ReadKey();
        }
    }
}
