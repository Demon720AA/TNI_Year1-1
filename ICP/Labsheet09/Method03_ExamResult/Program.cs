namespace Method03_ExamResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input mid-term score : ");
            int mid = int.Parse(Console.ReadLine());
            Console.Write("Input final    score : ");
            int final = int.Parse(Console.ReadLine());

            sumScore(mid, final);
            Console.ReadKey();
        }
        static void sumScore(int mid, int final)
        {
            Console.WriteLine();
            gradeResult(mid+final);
        }
        static void gradeResult(int sum)
        {
            Console.WriteLine("Your score is "+ (sum >= 50) ? "PASS" : "FAIL", $"({sum})");
        }
    }
}
