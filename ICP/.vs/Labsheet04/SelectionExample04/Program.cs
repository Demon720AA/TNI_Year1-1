namespace SelectionExample04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input mobile phone bill : ");
            double bill = double.Parse(Console.ReadLine());
            Console.Write("Input member type [G/B] : ");
            char member = char.Parse(Console.ReadLine());
            int discount = 0;
            if (member == 'g' || member == 'G')
            {
                discount = 5;
                Console.WriteLine($"\nGold member get discount {discount}%");
            }else if (member == 'b' || member == 'B')
            {
                discount = 10;
                Console.WriteLine($"\nBlue member get discount {discount}%");
            }
            else
            {
                Console.WriteLine("Regular customer no discount");
            }
            bill -= bill * ((double)discount / 100);
            Console.WriteLine($"Amount to be paid {bill:N2} baht.");

                Console.ReadKey();
        }
    }
}
