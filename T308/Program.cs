using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T308
{
    /// <summary>
    /// 迴圈倍數判斷
    /// 設計說明：
    ///   1.請使用continue設計一個程式，能夠計算1到使用者輸入的數中，哪些是3的倍數或5的倍數，並不是7的倍數。
    ///   2.輸出這些數的總和，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int x = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out x);
            for(int i = 1; i <= x; i++)
            {

                if (i % 7 == 0)
                {
                    continue;
                }
                if ( (i%3==0) | (i%5==0))
                {
                    total += i;
                }
            }
            Console.WriteLine($"Answer:{total}");
            Console.Read();
        }
    }
}
