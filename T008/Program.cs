using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T008
{
    /// 遞迴階乘計算
    /// 設計說明：
    ///   1.請寫一個程式持續輸入一個數 n，使用遞迴計算 n 的階乘，直到 n 輸入的
    ///     數值是 999 為止。
    ///   2.程式執行時，顯示【Input n(0 <= n <= 16):】要求輸入數值。
    ///   3.顯示如執行結果參考畫面。
    ///
    class Program
    {

        static int foo(int n)
        {
            if (n == 1)
            {
                return 1;

            }
            else
            {
                return n * foo(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input n(0 <= n <= 16):");
            string input = Console.ReadLine();
            while (input != "999")
            {
                int i = 0;
                bool result = int.TryParse(input, out i);
                if (result)
                {
                    if (i>0 & i <= 16)
                    {
                        //i *= foo(i);
                        int score = foo(i);                        
                        Console.WriteLine($"{i} 的階層 {score}");
                    }
                    Console.Write("Input n(0 <= n <= 16):");
                    input = Console.ReadLine();
                }
            }

            Console.Write("End");
            Console.Read();
        }
    }
}
