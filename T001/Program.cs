using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T001
{
    /// 偶數相加
    /// 設計說明：
    ///   1.請撰寫程式，接收輸入的兩個數字，若兩個數字皆是整數且為偶數，輸
    ///     出相加結果；若輸入的數字不符合要求，請轉換為數字 0。
    ///
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int x1 = 0;
            int x2 = 0;

            int.TryParse(s1, out x1);
            int.TryParse(s2, out x2);


            if ((x1 % 2) != 0)
            {
                x1 = 0;
            }

            if ((x2 % 2) != 0)
            {
                x2 = 0;
            }

            Console.Write($"{x1 + x2}");
            Console.Read();
        }
    }
}
