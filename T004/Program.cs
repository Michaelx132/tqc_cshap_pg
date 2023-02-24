using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T004
{
    /// 計算時間差
    /// 設計說明：
    ///   1.請撰寫程式，讓使用者輸入兩個 8 位數的整數作為日期，計算二者相差
    ///     的天數並輸出，若輸入文字或無法轉換，請輸出【error】。
    ///     ＊ 提示：使用 TimeSpan 時間計算
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            string x2 = Console.ReadLine();
            
            DateTime dt1;
            DateTime dt2;

            bool res1 = DateTime.TryParse($"{x1.Substring(0, 4)}/{x1.Substring(4, 2)}/{x1.Substring(6, 2)}", out dt1);
            bool res2 = DateTime.TryParse($"{x2.Substring(0, 4)}/{x2.Substring(4, 2)}/{x2.Substring(6, 2)}", out dt2);

            if (res1 & res2)
            {
                TimeSpan ts = dt2 - dt1;
                Console.Write($"{ts.Days}");

            }
            else
            {
                Console.Write("error");
            }

            Console.Read();
        }
    }
}
