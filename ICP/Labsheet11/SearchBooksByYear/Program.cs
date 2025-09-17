namespace SearchBooksByYear;

class Program
{
    static void Main(string[] args)
    {
        const string filePath = "D:\\TNI_Year1-1\\ICP\\Labsheet11\\textFile\\book.txt";

        try
        {
            Console.Write("Input the year of publication: ");
            int searchYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nList of book publication after {searchYear}");
            Console.WriteLine("-------------------------------------");

            using (StreamReader sr = new StreamReader(filePath))
            {
                string tmp = "";
                int count = 0;
                while ((tmp = sr.ReadLine()) != null)
                {
                    string[] book = tmp.Split("*");
                    int publicYear = int.Parse(book[3]);
                    if (publicYear >= searchYear)
                    {
                        Console.WriteLine($"{publicYear} {book[1]} ({book[3]})");
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("No books published this year");
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