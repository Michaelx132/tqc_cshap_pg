using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T401
{
    /// <summary>
    /// 尾端遞迴階層
    /// 設計說明：
    ///   1.畫面顯示[Input n (0 <= n <= 16):]，並於後方要求輸入一個整數。
    ///   2.分別使用尾端遞迴及迴圈計算 n 的階乘，直到輸入為999為止，執行結果如範例圖。
    /// </summary>
    class Program
    {
        //迴圈做法
        static int total_loop(int _x)
        {
            int result = 1;
            for(int i = 1; i <= _x; i++)
            {
                result *= i;
            }

            return result;
        }

        //尾遞迴做法
        static int foo(int _x,int _sum)
        {
            if (_x == 0)
            {
                return _sum;
            }
            else
            {
                return foo(_x - 1, _sum * _x);
            }
        }

        static int foo2(int _x)
        {
            if (_x == 0)
            {
                return 1;
            }
            else
            {
                return _x * foo2(_x - 1);
            }
        }

        static void Main(string[] args)
        {
            int total = 1;
            while (true)
            {
                int x = 0;
                Console.Write("Input n (0 <= n <= 16):");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 999)
                {
                    break;
                }else if ( x < 0 | x > 16)
                {
                    continue;
                }
                Console.WriteLine($"{x} 的階層(迴圈)={total_loop(x)}");
                Console.WriteLine($"{x} 的階層(遞迴)={foo2(x)}");
                Console.WriteLine($"{x} 的階層(尾遞迴)={foo(x, total)}");

            }
            Console.Read();
        }
    }
}
