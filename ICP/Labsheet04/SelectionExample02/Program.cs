namespace SelectionExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            string result;
            result = (num % 2 == 0) ? "Even" : "Odd";
            /*if (num % 2 == 0)
            {
                result = "Even";
            } else
            {
                result = "Odd";
            }*/

                Console.WriteLine($"{num} is {result} number");
            Console.ReadKey();
        }
    }
}
