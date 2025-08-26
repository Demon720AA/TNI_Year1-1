namespace SelectionExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "Odd";
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) result = "Even";

            Console.WriteLine($"\n{num} is {result} number");
            Console.ReadKey();
        }
    }
}
