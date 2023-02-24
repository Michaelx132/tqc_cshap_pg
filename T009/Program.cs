using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T009
{
    /// 陣列計算
    /// 設計說明：
    ///   1.請撰寫一個程式，由鍵盤輸入 10 個整數，並存放到一陣列。
    ///   2.程式執行時，顯示如執行結果參考畫面(1)，顯示【請輸入 10 個整數：】
    ///     並顯示【第 1 個整數：】，要求輸入第 1 個整數。
    ///   3.依序要求輸入第 1 個至第 10 個整數，顯示如執行結果參考畫面(2)。
    ///   4.判斷輸入 10 個整數後，計算陣列中大於 60 有幾個，這些大於 60 的數值
    //      總合及平均值，顯示如執行結果參考畫面(3)。
    /// 執行結果參考畫面：
    ///   1.程式執行時，顯示【請輸入 10 個整數：】並要求輸入第 1 個整數。
    ///   2.連續輸入 10 個整數。
    ///   3.計算陣列中大於 60 有幾個、這些數的總合及平均值。
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 10 個整數：");
            int[] i = new int[10];
            for(int x = 0; x < i.Count(); x++)
            {
                Console.Write($"第 {x+1} 個整數：");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out i[x]);
                if (!result)
                {
                    i[x] = 0;
                }
            }

            int total = 0;
            float count = 0;
            foreach(var xi in i)
            {
                if (xi > 60)
                {
                    total += xi;
                    count += 1;
                }
                //Console.WriteLine($"{xi}");
            }
            Console.Write($"大於 60 有{count}個、這些數的總合為{total}及平均值為{(total / count)}");
            Console.Read();

        }
    }
}
