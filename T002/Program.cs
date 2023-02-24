using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T002
{
    /// 判斷奇偶數
    /// 設計說明：
    ///   1 請撰寫程式，讓使用者輸入一個數字，若數字為奇數，呼叫 isodd 方法並
    ///     輸出【x is an odd number.】；若是偶數，呼叫 iseven 方法並輸出【x is an even
    ///     number.】；若輸入文字，請輸出【error】。
    ///     
    class Program
    {
        static void isodd(int x)
        {
            Console.Write($"{x} is an odd number.");
        }

        static void iseven(int x)
        {
            Console.Write($"{x} is an even number.");
        }

        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int x1 = 0;
            bool result = int.TryParse(s1, out x1);
            if (result)
            {
                if ((x1 % 2) == 0)
                {
                    iseven(x1);
                }
                else
                {
                    isodd(x1);
                }
            }
            else
            {
                Console.Write("error");
            }
            Console.Read();

        }
    }
}
