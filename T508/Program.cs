using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T508
{
    class Program
    {
        /// <summary>
        /// 泡泡排序法
        /// 設計說明：
        ///   1.使用泡泡排序法(Bubble Sort)撰寫程式。
        ///   2.請輸出泡泡排序法的排序過程，執行結果如範例圖。
        /// 泡泡排序法
        ///     一個數列中，比較二個元素，一直重複至沒有可以對調的時候即結束
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void score_foo(int[] x)
        {
            bool f = false;
            for(int i = 0; i < x.Length; i++)
            {
                if (i >= 1)
                {
                    if (x[i-1] > x[i])
                    {
                        f = true;
                        int tmp = x[i];
                        x[i] = x[i - 1];
                        x[i - 1] = tmp;
                        break;
                    }
                }
            }
            if (f)
            {
                foreach (var v in x)
                {
                    Console.Write($"{v} ");
                }
                Console.WriteLine();
                score_foo(x);
            }
        }

        static void Main(string[] args)
        {
            int[] vals = { 2, 3, 4, 5, 6, 7, 1, 9 };
            foreach (var v in vals)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
            score_foo(vals);
            Console.Read();

        }
    }
}
