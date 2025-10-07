namespace Method03_ExamResult;

class Program
{
    // static void Main(string[] args)
    // {
    //     Console.Write("Input mid-term score : ");
    //     int mid = int.Parse(Console.ReadLine());
    //     Console.Write("Input final    score : ");
    //     int final = int.Parse(Console.ReadLine());
    //
    //     sumScore(mid, final);
    //     Console.ReadKey();
    // }
    //
    // static void sumScore(int mid, int final)
    // {
    //     Console.WriteLine();
    //     gradeResult(mid+final);
    // }
    //
    // static void gradeResult(int sum)
    // {
    //     Console.WriteLine("Your score is " + ((sum >= 50) ? "PASS" : "FAIL") + $" ({sum})");
    // }
    
    static void Main(string[] args)
    {
        // Input mid-term and final scores
        Console.Write("Input mid-term score : ");
        int midScore = int.Parse(Console.ReadLine());
        Console.Write("Input final    score : ");
        int finalScore = int.Parse(Console.ReadLine());
        Console.WriteLine();
        // Calculate total score
        int sum = Sum(midScore, finalScore);
        // Check if pass or fail
        string result = PassOrFail(sum);
        // Display result in the Main() method
        Console.WriteLine($"Your score is {result} ({sum})");
        // Wait for user input before closing the console
        Console.ReadKey();
    }

    static int Sum(int midScore, int finalScore)
    {
        return midScore + finalScore;
    }

    static string PassOrFail(int sum)
    {
        return (sum >= 50) ? "PASS" : "FAIL";
    }
    
}