using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T309
{
    /// <summary>
    /// 迴圈正偶數相加
    /// 設計說明：
    ///   1.畫面顯示[請輸入 n 的值(n > 0，且為偶數)：]，並於後方要求輸入一個整數。
    ///   2.試用 do-while，計算 2+4+6+...+n 的總和，其中n為輸入的正偶數，
    ///     若不是則要求使用者在輸入，直到是正偶數為止，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int total = 0;
            do
            {
                Console.Write("請輸入 n 的值(n > 0，且為偶數)：");
                string input = Console.ReadLine();
                int.TryParse(input, out x);
                int i = 1;
                do
                {
                    if (i%2 == 0)
                    {
                        total += i;
                    }
                    i++;
                } while (i <= x);
            } while ((x < 0) | (x % 2 != 0));
            Console.Write($"2+4+...+{x}={total}");
            Console.Read();
        }
    }
}
