namespace Input03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\tINPUT RECIPIENT DATA");
            Console.WriteLine("------------------------------------");
            Console.Write("Input Name : ");
            string name = Console.ReadLine();
            Console.Write("Input House no. : ");
            string houseNum = Console.ReadLine();
            Console.Write("Input Road name : ");
            string roadName = Console.ReadLine();
            Console.Write("Input District : ");
            string district = Console.ReadLine();
            Console.Write("Input Province : ");
            string province = Console.ReadLine();
            Console.Write("Input Zip code : ");
            string zip = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Sent\t{name}\n\t{houseNum} {roadName} Rd.\n\t{district}\n\t{province} {zip}");
            Console.WriteLine("------------------------------------");


            Console.ReadKey();
        }
    }
}
