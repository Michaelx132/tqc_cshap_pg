using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T402
{
    /// <summary>
    /// 端遞迴次方計算
    /// 設計說明：
    ///   1.畫面顯示[Input m:]，並於後方要求輸入一個整數m。
    ///   2.畫面顯示[Input n:]，並於後方要求輸入一個整數n。
    ///   3.分別使用尾端遞迴及迴圈計算 m 的 n 次方，直到輸入為999為止，執行結果如範例圖。
    /// </summary>
    class Program
    {

        static int score_loop(int _m, int _n)
        {
            int total = 1;
            for (int i = 1; i <= _n; i++)
            {
                total *= _m;
            }
            return total;
        }

        static int score_foo(int _m,int _n)
        {
            if (_n == 1)
            {
                return _m;
            }
            else
            {
                return _m * score_foo(_m, _n - 1);
            }
        }

        static int score_foo2(int _m, int _n, int _sum)
        {
            if (_n == 0)
            {
                return _sum;
            }
            else
            {
                return score_foo2(_m, _n - 1, _m * _sum);
            }

        }

        static void Main(string[] args)
        {
            while (true)
            {
                int m;
                int n;
                Console.Write("Input m:");
                int.TryParse(Console.ReadLine(),out m);
                if (m==999)
                {
                    break;
                }
                Console.Write("Input n:");
                int.TryParse(Console.ReadLine(), out n);
                int sum=1;
                Console.WriteLine($"Ans (迴圈) = {score_loop(m,n)}");
                Console.WriteLine($"Ans (遞迴) = {score_foo(m, n)}");
                Console.WriteLine($"Ans (遞迴) = {score_foo2(m, n,sum)}");
                // score_foo2(


            }
            Console.Read();
        }
    }
}
