using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T506
{
    /// <summary>
    /// 三維陣列元素之和
    /// 設計說明：
    ///   1.計算陣列 A 內所有元素的總和，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int[,,] arys = { { { 22, 8, 7 }, { 9, 5, 3 }, { 7, 7, 1 } }, { { 6, 5, 4 }, { 3, 4, 9 }, { 9, 1, 2 } } };
            for(int x = 0; x < arys.GetLength(0); x++)
            {
                for (int y = 0; y < arys.GetLength(1); y++)
                {
                    for (int z = 0; z < arys.GetLength(2); z++)
                    {
                        score += arys[x, y, z];

                    }
                }
            }
            Console.WriteLine($"sum = {score}");
            Console.Read();

        }
    }
}
