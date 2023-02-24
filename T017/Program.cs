using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T017
{
    /// <summary>
    /// 一. 數學函數
    /// 數學函數
    /// 設計說明：
    ///   1.有一數學函數 f(x)=3(x^3)+2x-1。
    ///   2.撰寫一函數 f 用來傳回 f(x)的值，並分別計算 f(-3.2)、f(-2.1)、f(0)與f(2.1)。
    ///   3.函數 f(x)直取到小數第四位，執行結果如範例圖。
    ///     
    /// </summary>
    class Program
    {
        static string f(double x)
        {
            double result = 0;
            result = 3 * (Math.Pow(x, 3)) + (2 * x) - 1;
            return Math.Round(result,4).ToString("0.0000");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"f(-3.2):{f(-3.2)}");
            Console.WriteLine($"f(-2.1):{f(-2.1)}");
            Console.WriteLine($"f(0):{f(0)}");
            Console.WriteLine($"f(-.1):{f(2.1)}");
            Console.Read();
        }
    }
}
