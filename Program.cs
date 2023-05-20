
using System;

class Program
{
    static void Main()
    {
        int rowNumber;

        do
        {
            Console.Write("Enter the row number of Pascal's triangle: ");
            if (!int.TryParse(Console.ReadLine(), out rowNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (rowNumber < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }

            PrintPascalTriangle(rowNumber);
            break;
        } while (true);
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }

    static void PrintPascalTriangle(int rows)
    {
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }

            Console.WriteLine();
        }
    }
    
}
