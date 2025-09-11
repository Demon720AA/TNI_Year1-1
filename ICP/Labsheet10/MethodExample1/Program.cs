namespace MethodExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5] { 12, 52, 60, 78, 92 };
            int totoalNumber = sumArray(number);
            Console.WriteLine($"The summation of array is {totoalNumber}");
            Console.ReadKey();
        }
        static int sumArray(int[] num)
        {
            int sum = 0;
            foreach(int _num in num) sum += _num;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            return sum;
        }
    }
}
