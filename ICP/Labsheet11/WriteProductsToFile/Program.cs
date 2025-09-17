namespace WriteProductsToFile;

class Program
{
    static void Main(string[] args)
    {
        //win ver
        const string filePath = "D:\\TNI_Year1-1\\ICP\\Labsheet11\\textFile\\product.txt";
        //linux ver
        const string filePathLN= "/media/demon72/Main_Disk/TNI_Year1-1/ICP/Labsheet11/textFile/product.txt";
        
        try
        {
            //Use StreamWriter for writing to a file
            //'true' is parameter to append the content to the end of the file
            using (StreamWriter sw = new StreamWriter(filePathLN,true))
            {
                while (true)
                {
                    Console.Write("Input product Id(- to stop): ");
                    string productID = Console.ReadLine();
                    if (productID == "-")
                    {
                        break;
                    }

                    while (true)
                    {
                        Console.Write("Input product unit: ");
                        int unit = int.Parse(Console.ReadLine());
                        if (unit >= 0)
                        {
                            //Write to the file product.txt
                            sw.WriteLine($"{productID}\t{unit}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The unit cannot be negative. Please enter a ");
                        }
                    } // end while
                }// end while
            }
        }catch (IOException ex)
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
}