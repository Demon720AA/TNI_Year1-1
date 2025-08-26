namespace Array07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a message : ");
            string message = Console.ReadLine();
            int count = 0;
            foreach (char _message in message)
            {
                if (_message == ' ' || _message == '.')
                {
                    count++;
                }
            }
            Console.WriteLine($"\nThis message have {count} words");
            Console.ReadKey();
        }
    }
}
