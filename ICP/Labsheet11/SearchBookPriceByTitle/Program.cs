namespace SearchBookPriceByTitle;

class Program
{
    static void Main(string[] args)
    {
        const string filePath = "D:\\TNI_Year1-1\\ICP\\Labsheet11\\textFile\\book.txt";

        try
        {
            Console.Write("Input book title to search : ");
            string name = Console.ReadLine();
            Console.WriteLine();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string tmp = "";
                int count = 0;
                while ((tmp = sr.ReadLine()) != null)
                {
                    string[] book = tmp.Split("*");
                    string bookName = book[1];
                    double price = double.Parse(book[2]);
                    if (bookName == name)
                    {
                        Console.WriteLine($"{bookName} is {price:F2} baht.");
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine($"\"{name}\" is not found...");
                }

            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: Cannot open file 'book.txt'");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid year");
            
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error ocurred:");
        }
        Console.ReadKey();
    }
}