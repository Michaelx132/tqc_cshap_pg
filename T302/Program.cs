using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T302
{
    /// <summary>
    /// 完美數
    /// 設計說明：
    ///   1.一個數如果恰好等於它的因數(不含數字本身)之和，這個數就稱為[完美數]。
    ///   2.請設計一程式，找出1000以內的所有完美數，執行結果如範例圖。
    /// 說明：
    /// 4
    ///     4/1
    /// 6
    ///     6%1=6 餘 0
    ///     6%2=3 餘 0
    ///     6%3=2 餘 0
    ///     6%4=1 餘 2
    ///     6%5=1 餘 1
    ///     1+2+3 = 6
    /// 8
    ///     8%1=8 餘 0 
    ///     8%2=4 餘 0
    ///     8%3=2 餘 2
    ///     8%4=2 餘 0
    ///     8%5=1 餘 3
    ///     8%6=1 餘 2
    ///     8%7=1 餘 1
    ///     1+2+4 = 7
    /// 
    ///     
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            int sum = 0;
            Console.Write("1~1000中的完美數有:");
            for (i = 1; i <= 1000; i++)
            {
                sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write($"{sum} ");
                }
            }
            Console.WriteLine($"{ 6 % 1 }");
            Console.Read();
        }
    }
}
