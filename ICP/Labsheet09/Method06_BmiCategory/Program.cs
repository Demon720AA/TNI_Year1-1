namespace Method06_BmiCategory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== BMI Category ===");
        Console.Write("Weight (kg): ");double weightKg = double.Parse(Console.ReadLine());
        Console.Write("Height (cm): ");double heightCm = double.Parse(Console.ReadLine());
        double bmi = CalculateBmi(weightKg, heightCm);
        Console.WriteLine($"BMI: = {bmi:F1}, Category = {GetBmiCategory(bmi)})");
        Console.ReadKey();
    }

    static double CalculateBmi(double weightKg, double heightCm)
    {
        double heightM = heightCm / 100;
        return weightKg / (heightM*heightM);
    }

    static string GetBmiCategory(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        else if (bmi < 23) return "Normal";
        else if (bmi < 27.5) return "Overweight";
        else return "Obese";
    }
}