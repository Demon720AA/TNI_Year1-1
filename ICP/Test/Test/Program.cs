namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password, realpwd = "123";
            int count = 0;
            do
            {
                Console.Write("Input Password");
                if (count == 3) break;
                password = Console.ReadLine();
                count++;
            } while (password != realpwd);


            Console.ReadKey();
        }
    }
}
