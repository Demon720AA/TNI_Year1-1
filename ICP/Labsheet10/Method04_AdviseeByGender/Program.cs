using System.Reflection;

namespace Method04_AdviseeByGender
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
            char gender = ReadGender("Input gender of advisee : ");
            Console.WriteLine($"\nThe number of advisee is {CountAdviseesByGender(gender, advisee)}");
            Console.WriteLine("------------------------------------");
            PrintAdviseesByGender(gender, advisee);
            Console.ReadKey();
        }
        static char ReadGender(string prompt)
        {
            Console.Write(prompt);
            char gender = char.Parse(Console.ReadLine());
            while (gender != 'f' && gender != 'F' && gender != 'm' && gender != 'M')
            {
                Console.Write("Input gender of advisee, again : ");
                gender = char.Parse(Console.ReadLine());
            }
            return gender;
        }
        static char ParseGenderFromTitle(string title)
        {
            switch (title)
            {
                case "Mr.": return 'm';
                case "Ms.": return 'f';
                default: return '?';
            }
        }
        static int CountAdviseesByGender(char gender, string[] advisee)
        {
            int count = 0;
            foreach (string _adviss in advisee)
            {
                string[] student = _adviss.Split(',');
                string title = student[1];
                char g = ParseGenderFromTitle(title);
                if (g == gender) count++;
            }
            return count;
        }
        static void PrintAdviseesByGender(char gender, string[] advisee)
        {
            foreach (string _adviss in advisee)
            {
                string[] student = _adviss.Split(',');
                string id = student[0], title = student[1], name = student[2];
                char g = ParseGenderFromTitle(title);
                if (g == gender) Console.WriteLine($"{id}\t{name}");
            }
        }

    }
}
