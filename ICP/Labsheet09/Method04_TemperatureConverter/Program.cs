namespace Method04_TemperatureConverter;

class Program
{
    static void Main(string[] args)
    {
        ShowHeader();
        PrintConversionTable(0, 40, 10);
        Console.WriteLine($"Example for Converter:\n  100 C -> F = {Convert(100,'C','F'):F2}\n   32 F -> C = {Convert(32, 'F', 'C'):F2}\n  273.15 K -> C = {Convert(273.15, 'K', 'C'):F2}");
        Console.ReadKey();
    }

    static void ShowHeader()
    {
        Console.WriteLine("=== Temperature Converter ===\nCelsius  Fahrenheit  Kelvin");
    }

    static void PrintConversionTable(int startC, int endC, int step)
    {
        if (startC > endC)
        {
            int num = startC;
            startC = endC;
            endC = num;
        }
        if (step <= 0) step = 1;
        for (int i = startC; i <= endC; i += step)
        {
            Console.WriteLine($"{i,7}  {Convert(i,'C','F'),10:F2}  {Convert(i, 'C', 'K'),6:F2}");
        }
    }

    static double Convert(double value, char fromUnit, char toUnit)
    {
        if (fromUnit == 'C' || fromUnit == 'c')
        {
            if (toUnit == 'F' || toUnit == 'f')
            {
                return (value * 9 / 5) + 32;
            }else if (toUnit == 'K' || toUnit == 'k')
            {
                return value + 273.15;
            }else return value;
        }else if (toUnit == 'K' || toUnit == 'k')
        {
            if (fromUnit == 'F' || fromUnit == 'f')
            {
                return (value - 273.15) * 9 / 5 + 32;
            }else if (toUnit == 'C' || toUnit == 'c')
            {
                return value - 273.15;
            }else return value;
        }else if (toUnit == 'F' || toUnit == 'f')
        {
            if (fromUnit == 'k' || fromUnit == 'k')
            {
                return (value - 32) * 5 / 9 + 273.15;
            }
            else if (toUnit == 'C' || toUnit == 'c')
            {
                return (value - 32) * 5 / 9;
            }else return value;
        }
        else return -1;
    }
}