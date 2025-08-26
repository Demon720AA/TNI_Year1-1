namespace SelectionExample03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "Zero";
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            
            if (num > 0)
            {
                result = "Positive";
            }else if (num < 0)
            {
                result = "Negative";
            }

            Console.WriteLine($"\n{num} is {result} Number");
                Console.ReadKey();
        }
    }
}
