namespace DisplayStudentbyGroup;

class Program
{
    static void Main(string[] args)
    {
        //win ver
        const string filePath = "D:\\TNI_Year1-1\\ICP\\Labsheet11\\textFile\\StudentProgramming.txt";
        //linux ver
        const string filePathLN= "/media/demon72/Main_Disk/TNI_Year1-1/ICP/Labsheet11/textFile/StudentProgramming.txt";

        try
        {
            Console.Write("Enter the class group to display (e.g., 1 or 2): ");
            int group = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"Student in Class Group {group}");
            Console.WriteLine("--------------------------------------------------");

            using (StreamReader sr = new StreamReader(filePathLN))
            {
                int count = 0;
                string tmp = "";
                while ((tmp = sr.ReadLine()) != null)
                {
                    if (tmp == "") continue;
                    
                    string[] student = tmp.Split(","), name = student[2].Split(" ");
                    char font = name[1][0];
                    int groups = int.Parse(student[3]);
                    if (groups == group)
                    {
                        Console.WriteLine($"{++count}\t{student[0]}\t{font}.{name[0]}");
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: Cannot open file 'StudentProgramming.txt'");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter group");
            
        }
        catch (Exception e)
        {
            Console.WriteLine($"An unexpected error ocurred: {e.Message}");
        }
        Console.ReadKey();
    }
}