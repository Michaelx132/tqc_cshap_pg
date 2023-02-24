using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T007
{
    /// 整數連加
    /// 設計說明：
    ///   1.請使用 for loop 撰寫程式，輸入一個正整數 N，計算 1 + 2 + 3 + ... + N 的結果。
    ///   2.程式執行時，顯示【Input:】要求輸入一正整數，輸入完畢，於下方計算 1 + ... + N 的總和。
    ///   3.顯示如執行結果參考畫面。
    ///
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input:");
            string input = Console.ReadLine();
            int i = 0;
            bool result = int.TryParse(input, out i);
            int total = 0;
            if (result)
            {
                for(var x=1;x<=i;x++)
                {
                    total += x;
                }
                Console.Write($"{total}");
                Console.Read();
            }
        }
    }
}
