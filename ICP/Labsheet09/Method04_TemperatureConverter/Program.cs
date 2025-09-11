namespace Method04_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowHeader();
            PrintConversionTable(0, 40, 10);
            Console.WriteLine();
            Console.WriteLine($"Example for Converter:\n  100 C -> F = {Convert(100,'C','F'):F2}\n   32 F -> C = {Convert(32, 'F', 'C'):F2}\n  273.15 K -> C = {Convert(273.15, 'K', 'C'):F2}");
            Console.ReadKey();
        }
        static void ShowHeader()
        {
            Console.WriteLine("=== Temperature Converter ===\nCelsius  Fahrenheit  Kelvin");
        }
        static void PrintConversionTable(int startC, int endC, int step)
        {
            for (int i = startC; i <= endC; i += step)
            {
                Console.WriteLine($"{i,7}  {Convert(i,'C','F'),10:N2}  {Convert(i,'C', 'K'),6}");
            }
        }
        static double Convert(double value, char fromUnit, char toUnit)
        {
            if (fromUnit == 'C')
            {
                if (toUnit == 'F')
                {
                    return (value * 9 / 5) + 32;
                }
                else if (toUnit == 'K')
                {
                    return value + 273.15;
                }
                else
                {
                    return value;
                }
            }else if (fromUnit == 'F')
            {
                if (toUnit == 'C')
                {
                    return (value - 32) * 5 / 9;
                }
                else if (toUnit == 'K')
                {
                    return (value - 32) * 5 / 9 + 273.15;
                }
                else
                {
                    return value;
                }
            }else if(fromUnit == 'K')
            {
                if (toUnit == 'C')
                {
                    return value - 273.15;
                } else if (toUnit == 'F')
                {
                    return (value - 273.15) * 9 / 5 + 32;
                }
                else
                {
                    return value;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
