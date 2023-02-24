using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T404
{
    /// <summary>
    /// 遞迴函數
    /// 設計說明：
    ///   1.畫面顯示[Input the number n:]，並於後方要求輸入一個整數 n(n>=1 )。
    ///   2.請利用下面的公式，撰寫遞迴函數 sum2，(a.) sum2(1)=2 (b.) sum2(n)=sum2(n-1)+2* n。
    ///   3.將 n 代入函數中，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {

        static int sum2(int _n)
        {
            if (_n == 1)
            {
                return 2;
            }
            else
            {
                return (2 * _n) + sum2(_n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input the number n:");
            int x;
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine($"Ans:{sum2(x)}");


            Console.Read();
        }
    }
}
