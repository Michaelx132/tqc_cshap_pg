using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T504
{
    /// <summary>
    /// 費氏數
    /// 設計說明：
    ///   1.請先宣告一個大小為10的陣列，並將最前面二個陣列指定為費氏數的初始值，再
    ///   2.用初始使值計算其餘的費氏數，再以分析方式，顯示此費氏數的前10個數值，執行結果如範例圖。
    /// 費式數
    /// 數列 Fₙ = Fₙ₋₁ + Fₙ₋₂
    /// 例如：{3,5,n}，則n =  8
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[10];
            scores[0] = 1;
            scores[1] = 2;
            for(int x = 2; x < scores.Length; x++)
            {

                scores[x] = scores[x - 1] + scores[x - 2];
            }

            foreach(var g in scores)
            {
                Console.WriteLine($"{g}");
            }
            Console.Read();
        }
    }
}
