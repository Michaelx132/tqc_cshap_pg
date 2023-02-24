using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T510
{
    /// <summary>
    /// 二分搜尋法
    /// 設計說明：
    ///   1.畫面顯示[請輸入要找尋的資料：]，並於後方要求輸入要找尋的資料。
    ///   2.請輸出二分搜尋法的搜尋過程，並顯示[經過 y 次的尋找]，若資料不
    ///     在陣列裡則顯示[n不再陣列中]，若在陣列裡則顯示[您要找的資料在陣
    ///     列中的第x個位子]，執行結果如範例圖。
    ///     
    /// </summary>
    class Program
    {
        static void search(int[] data)
        {
            int x;
            int s = 0;
            int e = data.Length - 1;
            int d;
            int i = 1;
            Console.Write("請輸入要找尋的資料：");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine($"尋找區間：{s}({data[s]})..{e}({data[e]}),中間：{(s+e/2)}({data[(s+e)/2]})");
            do
            {
                d = (s + e) / 2;
                //Console.WriteLine($"尋找區間：{s}({data[s]})..{e}({data[e]}),中間：{d}({data[d]})");
                if (data[d] > x)
                {
                    e = d - 1;
                }
                else if (data[d] < x)
                {
                    s = d + 1;
                }
                Console.WriteLine($"尋找區間：{s}({data[s]})..{e}({data[e]}),中間：{(s+e)/2}({data[(s + e) / 2]})");
                i++;

            } while (data[d] != x && e>s);
            Console.WriteLine($"經過 {i} 次的尋找");
            if (x == data[(s+e) / 2])
            {
                Console.WriteLine($"您要找的資料在陣列中的第 {d} 個位子");
            }
            else
            {
                Console.WriteLine($"{x} 不在陣列中");
            }


        }
        static void Main(string[] args)
        {
            int[] data = { 5, 9, 13, 15, 17, 19, 25, 30, 45 };
            search(data);
            Console.Read();
        }
    }
}
