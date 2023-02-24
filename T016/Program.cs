using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T016
{
    /// <summary>
    /// 一. 基本認識
    /// 設計說明：
    ///   1.於畫面顯示[請輸入您的姓名:]，並於後方輸入姓名。
    ///   2.於畫面顯示要求輸入銅板個數，並依序要求輸入1元、5元、10元、50元硬幣數量。
    ///   3.輸出總金額，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.Write("請輸入您的姓名:");
            string input = Console.ReadLine();
            Console.WriteLine($"Hi, {input}, 請輸入你的銅板的個數: ");
            Console.Write("請輸入1元數量:");
            int x1 = 0;
            int.TryParse(Console.ReadLine(), out x1);
            total += x1 * 1;
            Console.Write("請輸入5元數量:");
            int x5 = 0;
            int.TryParse(Console.ReadLine(), out x5);
            total += x5 * 5;
            Console.Write("請輸入10元數量:");
            int x10 = 0;
            int.TryParse(Console.ReadLine(), out x10);
            total += x10 * 10;
            Console.Write("請輸入50元數量:");
            int x50 = 0;
            int.TryParse(Console.ReadLine(), out x50);
            total += x50 * 50;
            Console.Write($"你的錢總共有：{total/1000} 千 {total%1000/100} 百 {total%1000%100/10} 十 {total%10} 元 ");
            Console.Read();
        }
    }
}
