using System.Numerics;

namespace Method02_CalculateNumber;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Input number 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input number 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input operator : ");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Summation(num1, num2);
                    break;
                case '-':
                    Subtraction(num1, num2);
                    break;
                case '*':
                    Multiplication(num1, num2);
                    break;
                case '/':
                    Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Error : Operator not found");
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Error : Input {e.Message}");
        }
        Console.ReadKey();
    }

    static void Summation(int num1, int num2)
    {
        Console.WriteLine($"\nThe result of Summation is {num1 + num2}");
    }

    static void Subtraction(int num1, int num2)
    {
        Console.WriteLine($"\nThe result of Subtraction is {num1 - num2}");
    }

    static void Multiplication(int num1, int num2)
    {
        Console.WriteLine($"\nThe result of Multiplication is {num1 * num2}");
    }

    static void Division(int num1, int num2)
    {
        Console.WriteLine($"\nThe result of Division is {num1 / num2}");
    }
}