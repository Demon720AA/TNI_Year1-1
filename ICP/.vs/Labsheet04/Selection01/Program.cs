namespace Selection01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input exam score : ");
            double score = double.Parse(Console.ReadLine());
            Console.WriteLine();
            string result = "PASS";
            if (score < 50)
            {
                result = "FAIL";
            }
            Console.Write($"The result is {result}");
            Console.ReadKey();
        }
    }
}
