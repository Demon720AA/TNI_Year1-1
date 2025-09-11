namespace Method03_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many subject to enroll : ");
            int num = int.Parse(Console.ReadLine());
            string[] ids = new string[num];
            int[] credits = new int[num];
            float[] grades = new float[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("\nInput subject Id\t: ");
                ids[i] = Console.ReadLine();
                Console.Write("Input subject credit\t: ");
                credits[i] = int.Parse(Console.ReadLine());
                Console.Write("Input subject grade\t: ");
                grades[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            showHeader();
            showGrade(ids, credits, grades);
            float gpa = calculateGPA(ids, credits, grades);
            Console.WriteLine($"GPA = {gpa:0.00}");
            Console.ReadKey();
        }
        static void showHeader()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("ID\t\tCREDIT\t\tGRADE");
            Console.WriteLine("-------------------------------------------------");
        }
        static void showGrade(string[] ids, int[] credits, float[] grades)
        {
            for (int i = 0; i < ids.Length; i++)
            {
                Console.WriteLine($"{ids[i]}\t\t{credits[i],4}\t\t{grades[i]:0.0}");
            }
            Console.WriteLine("-------------------------------------------------");
        }
        static float calculateGPA(string[] ids, int[] credits, float[] grades)
        {
            float gpa = 0, credit = 0;
            for (int i = 0; i < ids.Length; i++)
            {
                gpa += credits[i] * grades[i];
                credit += credits[i];
            }
            return gpa / credit;
        }
    }
}
