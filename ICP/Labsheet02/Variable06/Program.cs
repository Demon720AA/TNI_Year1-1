namespace Variable06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentId = "1913110001";
            int subject = 7, credit = 3000, tuitionFees = 5000, total = subject * credit + tuitionFees;
            Console.WriteLine($"STUDENT ID = {studentId}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"ENROLLMENT\t\t{subject} Subject. ({credit} baht/subject)");
            Console.WriteLine($"TOTAL PRICE\t{total,12:C0}");

            Console.ReadKey();
        }
    }
}
