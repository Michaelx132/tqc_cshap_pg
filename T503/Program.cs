using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T503
{
    /// <summary>
    /// 矩陣之和
    /// 設計說明：
    ///   1.撰寫一個函數，用來計算矩陣A與B的和，並將結果放在矩陣C裡。
    ///   2.執行結果如範例圖。
    /// </summary>
    class Program
    {
        static void show_array(int[,] ary)
        {
            for(int i = 0; i < ary.GetLength(0); i++)
            {
                for(int j = 0; j < ary.GetLength(1); j++)
                {
                    Console.Write($"{ary[i,j].ToString("00")} ");
                }
                Console.WriteLine();
            }
        }

        static void sum_array(int[,] _a, int[,] _b, int[,] _c)
        {
            for (int i = 0; i < _c.GetLength(0); i++)
            {
                for (int j = 0; j < _c.GetLength(1); j++)
                {
                    _c[i, j] = _a[i, j] + _b[i, j];
                }

            }

        }
        static void Main(string[] args)
        {
            int row = 2;
            int col = 3;
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] B = { { 7, 8, 9 }, {10,11,12 } };
            int[,] C = new int[row, col];
            Console.WriteLine($"陣列A的內容為(3x3):");
            show_array(A);
            Console.WriteLine($"陣列B的內容為(3x3):");
            show_array(B);
            Console.WriteLine($"陣列C的內容為(3x3):");
            sum_array(A, B, C);
            show_array(C);

            Console.Read();

        }
        
    }
}
