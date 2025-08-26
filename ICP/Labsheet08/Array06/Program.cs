namespace Array06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' }, VOWEL = { 'A', 'E', 'I', 'O', 'U'};
            int[] count = new int[5];
            Console.Write("Input a message : ");
            string message = Console.ReadLine();
            Console.WriteLine();
            foreach (char _message in message)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (_message == vowel[j] || _message == VOWEL[j])
                    {
                        count[j]++;
                    }
                }
            }
            for (int j = 0; j < 5; j++)
            {
                if (count[j] > 0)
                {
                    Console.WriteLine($"The number of letter '{VOWEL[j]}' is {count[j]}");
                }
            }
            Console.ReadKey();
        }
    }
}
