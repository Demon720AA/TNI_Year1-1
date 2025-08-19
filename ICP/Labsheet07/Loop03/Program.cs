namespace Loop03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many student in classroom : ");
            int student = int.Parse(Console.ReadLine()), score, pass = 0;
            Console.WriteLine("------------------------------------------------------------------");
            for (int i = 1;i<=student;i++)
            {
                Console.Write($"Input score student {i} :");
                score = int.Parse(Console.ReadLine());
                if (score < 0 || score > 100)
                {
                    while (score < 0 || score > 100)
                    {
                        Console.Write($"Input score student {i}, again :");
                        score = int.Parse(Console.ReadLine());
                    }
                }
                if (score >= 50)
                {
                    pass++;
                }

            }
            Console.WriteLine("------------------------------------------------------------------");
            if (pass > student - pass)
            {
                Console.WriteLine("The number of pass students greater than fail students.");
            } else if (pass < student - pass)
            {
                Console.WriteLine("The number of pass students less than fail students.");
            } else if (pass == student - pass)
            {
                Console.WriteLine("The number of both pass and fail students are equal.");
            }
                Console.ReadKey();
        }
    }
}
