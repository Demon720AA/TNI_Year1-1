namespace ExampleSelection01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight(kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter hight(cm): ");
            double hight = double.Parse(Console.ReadLine());
            hight = hight / 100;
            double bmi = weight / (hight * hight);
            Console.WriteLine($"Body Mass Index (BMI): {bmi:F2}");
            /*string category;
            if (bmi >= 30)
            {
                category = "Obese";
            } else if (bmi >= 25)
            {
                category = "Over weight";
            } else if (bmi >= 18.5)
            {
                category = "Noemal weight";
            } else
            {
                category = "Under weight";
            }*/
            //refactor
            Console.WriteLine("=======================");
            string category = bmi switch 
            { 
                <18.5 => "Underweight",
                <25 => "Normalweight",
                <30 => "Overweight",
                _ => "Obese"
            };

            Console.WriteLine($"category: {category}");
            Console.ReadKey();
        }
    }
}
