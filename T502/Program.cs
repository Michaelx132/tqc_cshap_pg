using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T502
{
    /// <summary>
    /// 浮點數計算
    /// 設計說明：
    ///   1.畫面顯示[請輸入學生人數：]，並於後方依序要求輸入學生人數。
    ///   2.再於下方依序要求輸入n個學生的成績，將學生的成績存放到陣列裡。
    ///   3.計算出人數、總分及平均值(不限小數點位數)，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("請輸入學生人數：");
            int.TryParse(Console.ReadLine(), out x);
            double[] score = new double[x];
            for( int i = 0; i < x; i++)
            {
                Console.Write($"第{i+1}個學生的成績:");
                double.TryParse(Console.ReadLine(), out score[i]);

            }

            int totalp = 0;
            double totals = 0;
            foreach(var y in score)
            {
                totalp++;
                totals += y;
            }
            Console.WriteLine($"人數:{totalp}");
            Console.WriteLine($"總分:{totals}");
            Console.WriteLine($"平均:{totals/totalp}");



            Console.Read();

        }
    }
}
