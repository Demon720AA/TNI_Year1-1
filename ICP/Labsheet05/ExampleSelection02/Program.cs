namespace ExampleSelection02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input car type (1, 2, 3): ");
            int type = int.Parse(Console.ReadLine());
            /*int carPrice;
            switch (type)
            {
                case 1: carPrice = 50; break;
                case 2: carPrice = 75; break;
                case 3: carPrice = 110; break;
                default: carPrice = -1; break;
            }*/
            //switch expression
            int carPrice = type switch
            {
                1 => 50,
                2 => 75,
                3 => 110,
                _ => -1
            };
            if (carPrice == -1)
            {
                Console.WriteLine("Invalid car type.");
                return;
            }
            
                Console.WriteLine($"Price of car type = {carPrice} baht.");

            Console.Write("Input money : ");
            double money = double.Parse(Console.ReadLine());
            if (money > carPrice)
            {
                Console.WriteLine($"Get change {money-carPrice} Baht.");
            }else if (money < carPrice)
            {
                Console.WriteLine($"Get more {carPrice-money} Baht.");
            }
            Console.WriteLine("Thank you");


                Console.ReadKey();
        }
    }
}
