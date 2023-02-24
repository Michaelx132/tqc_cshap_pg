using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T307
{
    /// <summary>
    /// 電腦周邊費用總計
    /// 設計說明：
    ///   1.畫面顯示[請輸入消費金額，或輸入-1結束：]，並於後方要求輸入一個整數。
    ///   2.使用 do-while 重複執行，直到輸入-1結束，結束時輸出電腦周邊總消費的總和，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            int total = 0;
            do
            {
                Console.Write("請輸入消費金額，或輸入-1結束：");
                string input = Console.ReadLine();
                int.TryParse(input, out x);
                if (x != -1)
                {
                    total += x;
                }
            } while (x != -1);
            Console.WriteLine($"電腦週邊總消費:{total}");
            Console.Read();
        }
    }
}
