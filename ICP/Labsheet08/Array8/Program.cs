namespace Array8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a mesasge : ");
            string message = Console.ReadLine();
            string upper = "";

            foreach (int i in message)
            {
                if (i >= 97 && i <= 122)
                {
                    upper += (char)(i - 32);
                }
                else if (i >= 65 && i <= 90)
                {
                    upper += (char)(i + 32);
                }
                else
                {
                    upper += (char)i;
                }
            }
            Console.WriteLine($"\nShow in opposite case = {upper}");

            Console.ReadKey();
        }
    }
}
