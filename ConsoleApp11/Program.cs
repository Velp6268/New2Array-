using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            TwoDimensionArray arr = new();
            arr.ArrayInit();

            for (int i = 0; i < arr.Dim2Array.GetLength(0); i++)
            {
                for (int j = 0; j < arr.Dim2Array.GetLength(1); j++)
                    Console.Write($"{arr.Dim2Array[i, j]}\t");
                Console.WriteLine();
            }

            Console.WriteLine($"\nУмноженное числа меньше, чем на 10 = {arr.MultiplyLess10()}");
            Console.ReadKey();
        }
    }
}