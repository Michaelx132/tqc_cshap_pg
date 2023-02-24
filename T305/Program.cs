using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T305
{
    /// <summary>
    /// 迴圈計算次方
    /// 設計說明：
    ///   1.畫面顯示[Inout:]，並於下方要求輸入二個整數 m、n，並以空格鍵分隔。
    ///   2.並用一個類別方法及 while loop 計算 m 的 n 次方，直到輸入m=999為止，執行結果如範例圖。
    /// </summary>
    class Program
    {
        public static double Score(int _m,int _n)
        {
            double m = _m;
            int total = 1;
            while (_n > 0)
            {
                total *= _m;
                _n--;
            }
            return total;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int m = 0;
                int n = 0;
                Console.WriteLine("Inout:");
                string[] inputs = Console.ReadLine().Split(' ');
                int.TryParse(inputs[0], out m);
                int.TryParse(inputs[1], out n);
                if (m == 999)
                {
                    break;
                }
                Console.WriteLine($"{Score(m,n)}");
            }
            Console.Read();
        }
    }
}
