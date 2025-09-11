namespace Method05_SeeAdvisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] advisee =
            {
                "59121100-8,Mr.,Sarun Kitcharoen,3.79",
                "59121101-6,Ms.,Pawarin Kunanake,3.33",
                "59121102-4,Mr.,Anan Phasuk,2.95",
                "59121103-2,Mr.,Pattarapong Krairaveevit,3.29",
                "59121104-0,Ms.,Sasithorn Wongyai,3.82",
                "59121105-7,Mr.,Kittipong Chaiyapruk,2.74",
                "59121106-5,Ms.,Napassanan Sirilak,3.55",
                "59121107-3,Mr.,Thanakorn Meesuk,2.88",
                "59121108-1,Ms.,Jiraporn Chotika,3.91",
                "59121109-9,Ms.,Ponchai Tantrasai,2.91"
            };
            float threshold = ReadThreshold("Input grade to see advisor (less than) : ");
            Console.WriteLine();
            Console.WriteLine("List of students that need to meet with the advisor:");
            Console.WriteLine("----------------------------------------------------");
            ShowAdviseeBelow(threshold, advisee);
            Console.ReadKey();
        }
        static float ReadThreshold(string prompt)
        {
            Console.Write(prompt);
            return float.Parse(Console.ReadLine());
        }
        static void ShowAdviseeBelow(float threshold, string[] advisee)
        {
            int count = 1;
            foreach(string _advisee in advisee)
            {
                string[] student = _advisee.Split(',');
                string id = student[0], name = student[2];
                double grade = double.Parse(student[3]);
                if (grade < threshold)
                {
                    Console.WriteLine($"{count}){id}\t{grade}\t{name}");
                }
            }
        }
    }
}
