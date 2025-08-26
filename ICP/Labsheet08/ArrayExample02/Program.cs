namespace ArrayExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student;
            Console.Write("Input number of student: ");
            student = int.Parse(Console.ReadLine());
            Console.WriteLine("*************************************************");
            double[] score = new double[student];
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write($"Input score student {i+1:00}: ");
                score[i] = double.Parse( Console.ReadLine() );
                if (score[i] < 0 || score[i] > 100)
                {
                    i--;
                    continue;
                }
            }

            int pass = 0;
            foreach (int i in score)
            {
                if (score[i] >= 50)
                {
                    pass++;
                }
            }

            Console.WriteLine($"\nPASS = {pass} FROM {score.Length}");
            Console.WriteLine($"\nFAIL = {student-pass} FROM {score.Length}");

            Console.ReadKey();
        }
    }
}
