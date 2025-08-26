namespace SelectionExample02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            //Conditional Operator (if..else)
            //เงื่อนไข = true  output "?"
            //เงื่อนไข = false output ":"
            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"\n{num} is {result} number");
            Console.ReadKey();
        }
    }
}
