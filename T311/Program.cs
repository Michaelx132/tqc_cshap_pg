using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T311
{
    /// <summary>
    /// 設計說明：
    ///   1.請撰寫程式，讓使用者輸入多筆金額，input integer:
    ///   2.直至使用者輸入0則結束
    ///   3.將使用者輸入的金額加總起來，輸出 Sum:總金額
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> total = new List<int>();
            int score = 0;
            int x = 0;
            while (true)
            {
                Console.Write($"Input Integer:");
                bool isInt = int.TryParse(Console.ReadLine(), out x);
                if (isInt & x != 0)
                {
                    total.Add(x);
                }
                else
                {
                    Console.WriteLine($"end");
                    break;
                }
            }
            foreach(var item in total)
            {
                score += item;
            }
            Console.WriteLine($"Sum:{score}");
            Console.Read();
            
        }
    }
}
