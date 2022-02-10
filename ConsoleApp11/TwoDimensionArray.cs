using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TwoDimensionArray
    {
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public int StartRandom { get; set; }
        public int EndRandom { get; set; }
        public int[,] Dim2Array { get; private set; }


        internal Random random;

        public TwoDimensionArray()
        {
            RowsCount = 5;
            ColumnsCount = 5;
            EndRandom = 99;
        }


        public TwoDimensionArray(int rows, int colls)
        {
            RowsCount = rows >= 0 ? rows : 5;
            ColumnsCount = colls >= 0 ? colls : 5;
            EndRandom = 99;
        }


        public TwoDimensionArray(int rows, int colls, int start, int end)
        {
            RowsCount = rows >= 0 ? rows : 5;
            ColumnsCount = colls >= 0 ? colls : 5;
            StartRandom = start;
            EndRandom = end > start ? end : 99;
        }


        public void ArrayInit()
        {
            random = new Random();
            EndRandom++;

            Dim2Array = new int[RowsCount, ColumnsCount];

            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    Dim2Array[i, j] = random.Next(StartRandom, EndRandom);
        }


        public int MultiplyLess10()
        {
            return Dim2Array.Cast<int>().Where(x => x > 0 && x < 10).Aggregate((a, b) => a * b);
        }
    }
}