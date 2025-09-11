<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Method06_BmiCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            Console.WriteLine("=== BMI Calculator ===");
            Console.Write("Weight (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Height (cm): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double numBmi = CalculateBmi(weight, height);
            string bmi = GetBmiCategory(numBmi);
            Console.WriteLine($"BMI = {numBmi:F1}, Category = {bmi}");
            Console.ReadKey();
        }
        static double CalculateBmi(double weightKg, double heightCm)
        {
            double heightM = heightCm / 100;
            return weightKg / (heightM *heightM);
        }
        static string GetBmiCategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }else if (bmi < 23)
            {
                return "Normal";
            }else if (bmi < 27.5)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
=======
﻿namespace Method06_BmiCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            Console.WriteLine("=== BMI Calculator ===");
            Console.Write("Weight (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Height (cm): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double numBmi = CalculateBmi(weight, height);
            string bmi = GetBmiCategory(numBmi);
            Console.WriteLine($"BMI = {numBmi:F1}, Category = {bmi}");
            Console.ReadKey();
        }
        static double CalculateBmi(double weightKg, double heightCm)
        {
            double heightM = heightCm / 100;
            return weightKg / (heightM *heightM);
        }
        static string GetBmiCategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }else if (bmi < 23)
            {
                return "Normal";
            }else if (bmi < 27.5)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
>>>>>>> 22adc4b184a345020fe652716d36de13deaa9b98
=======
﻿namespace Method06_BmiCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            Console.WriteLine("=== BMI Calculator ===");
            Console.Write("Weight (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Height (cm): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double numBmi = CalculateBmi(weight, height);
            string bmi = GetBmiCategory(numBmi);
            Console.WriteLine($"BMI = {numBmi:F1}, Category = {bmi}");
            Console.ReadKey();
        }
        static double CalculateBmi(double weightKg, double heightCm)
        {
            double heightM = heightCm / 100;
            return weightKg / (heightM *heightM);
        }
        static string GetBmiCategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }else if (bmi < 23)
            {
                return "Normal";
            }else if (bmi < 27.5)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
>>>>>>> 22adc4b184a345020fe652716d36de13deaa9b98
