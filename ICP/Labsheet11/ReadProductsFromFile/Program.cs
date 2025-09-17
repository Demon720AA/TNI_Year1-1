namespace ReadProductsFromFile;

class ReadProductsFromFile
{
    static void Main(string[] args)
    {
        const string filePath = "D:\\TNI_Year1-1\\ICP\\Labsheet11\\textFile\\product.txt";
        WriteHeader();
        try
        {
            //Use 'using' statement to ensure the StreamReader is closed
            using (StreamReader sr = new StreamReader(filePath))
            {
                string tmp = "";
                while ((tmp = sr.ReadLine()) != null)
                {
                    string[] products = tmp.Split('\t');
                    string productID = products[0];
                    int unit = int.Parse(products[1]);
                    Console.Write($"{productID}\t\t{unit}\t\t");
                    if (unit == 0)
                    {
                        Console.WriteLine("OUT OF STOCK");
                    }else if (unit >= 10 && unit <= 20)
                    {
                        Console.WriteLine("LOW");
                    }else if (unit > 20)
                    {
                        Console.WriteLine("NORMAL");
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error ocurred:");
        }
        finally
        {
            
            Console.WriteLine("----------------------------------------------------------------");
        }
        Console.ReadKey();
    }

    static void WriteHeader()
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("ID\t\tUnit\t\tStatus");
        Console.WriteLine("----------------------------------------------------------------");
    }
}