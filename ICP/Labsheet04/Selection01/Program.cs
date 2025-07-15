namespace Selection01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.Write("Input exam score : ");
            double num = double.Parse(Console.ReadLine());
            result = (num < 50) ? "FAIL" : "PASS";
            Console.WriteLine($"\nThe result in {result}");
            Console.ReadKey();
        }
    }
}
