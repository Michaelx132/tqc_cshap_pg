using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T303
{
    /// <summary>
    /// 點餐費用
    /// 設計說明：
    ///   1.畫面顯示[Please enter meal dollars -1 too stop:]，並於後方要求輸入一個點餐費用。
    ///   2.重複執行直到輸入-1為止，輸入-1後輸出點餐數量、所有點餐的總額費用及平均負擔費用，
    ///     平均值取自小數第二位，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double price = 0;
            while (true)
            {
                int x = 0;
                Console.Write("Please enter meal dollars -1 too stop:");
                string input = Console.ReadLine();
                int.TryParse(input, out x);
                if (x == -1)
                {
                    break;
                }
                count += 1;
                price += x;
            }
            Console.WriteLine($"餐點總費用:{price}");
            Console.WriteLine($"{count}道餐點平均費用為:{Math.Round( (price / count),2)}");
            Console.Read();
        }
    }
}
