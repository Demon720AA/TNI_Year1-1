namespace DisplayStudentsForAdvisor;

class Program
{
    static void Main(string[] args)
    {
        const string filePath = "D:\\TNI_Year1-1\\ICP\\Labsheet11\\textFile\\AdvisorDuty.txt";

        try
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("List of student who must visit their Advisor");
            Console.WriteLine("--------------------------------------------------");

            using (StreamReader sr = new StreamReader(filePath))
            {
                int count = 0;
                string tmp = "";
                while ((tmp = sr.ReadLine()) != null)
                {
                    string[] student = tmp.Split(",");
                    double grade = double.Parse(student[4]);
                    if (grade < 2.5)
                    {
                        Console.WriteLine($"Student is {++count}: {student[0]} {student[1]} {student[2]} ({grade:F2})");
                    }
                }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"There are a total of {count} students.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: Cannot open file 'Adcisor Duty.txt'");
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error ocurred:");
        }
        Console.ReadKey();
    }
}