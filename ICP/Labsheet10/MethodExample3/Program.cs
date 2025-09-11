namespace MethodExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] advisee = {
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
            Console.WriteLine("The number of advisee is {0}", advisee.Length);
            Console.WriteLine();
            showHeader();
            showAdvisee(advisee);
            Console.ReadKey();
        }
        static void showHeader()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\t\tGRADE\tFULLNAME");
            Console.WriteLine("--------------------------------------------------");
        }
        static void showAdvisee(string[] advisee)
        {
            foreach (string _advisee in advisee)
            {
                string[] student = _advisee.Split(',');
                string id = student[0], title = student[1], name = student[2];
                double gpa = double.Parse(student[3]);

                Console.WriteLine($"{id}\t{gpa:0.0}\t{name}");
            }
        }
    }
}
