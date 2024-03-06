using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many columns: ");
            int columns = int.Parse(Console.ReadLine());
            Console.Write("Enter how many rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int currentRow = 1; currentRow <= rows; currentRow++)
            {
                //repeat for each row
                for (int currentCol = 1; currentCol <= columns; currentCol++)
                {
                    //repeat for each * on row
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("Enter how many asterisks: ");
            int maxStar = int.Parse(Console.ReadLine());
            for (int r = 1; r <= maxStar; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }        
    }
}