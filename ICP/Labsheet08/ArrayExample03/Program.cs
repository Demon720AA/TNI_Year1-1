namespace ArrayExample03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' }, VOWEL = { 'A', 'E', 'I', 'O', 'U' };
            Console.Write("Input a message : ");
            string message = Console.ReadLine();
            //message = message.ToLower();
            foreach (char _message in message)
            {
                for (int i = 0; i < vowel.Length; i++)
                {
                    if (_message == vowel[i] || _message == VOWEL[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"The number of vowels in message is {count}");

            Console.ReadKey();
        }
    }
}
