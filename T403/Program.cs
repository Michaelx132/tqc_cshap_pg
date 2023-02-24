using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T403
{
    /// <summary>
    /// 遞迴最大公因數
    /// 設計說明：
    ///   1.畫面顯示[Input m:]，並於後方要求輸入一個整數m。
    ///   2.畫面顯示[Input n:]，並於後方要求輸入一個整數n。
    ///   3.使用尾端遞迴計算 m 與 n 的最大公因數，直到輸入為999為止，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {

        static int score_loop(int _m, int _n)
        {
            while ( _n > 0)
            {
                int val = _m%_n;
                if (val == 0)
                {
                    break;
                }
                _m = _n;
                _n = val;
            }
            return _n;
        }

        static int score_foo(int _m ,int _n,int _score)
        {
            if(_m%_n > 0)
            {
                _score = _m % _n;
                return score_foo(_n, _score, _m % _n);
            }
            else
            {
                return _score;
            }
        }

        static void Main(string[] args)
        {
            int m;
            int n;
            while (true)
            {

                Console.Write("Input m:");
                int.TryParse(Console.ReadLine(), out m);
                if (m == 999)
                {
                    break;
                }
                Console.Write("Input n:");
                int.TryParse(Console.ReadLine(), out n);
                int score = n;
                Console.WriteLine($"{m},{n}最大公因數為(迴圈):{score_loop(m, n)}");
                Console.WriteLine($"{m},{n}最大公因數為(尾端遞迴):{score_foo(m,n,score)}");
                //Console.WriteLine($"{m},{n}");

            }
            Console.Read();
        }
    }
}
