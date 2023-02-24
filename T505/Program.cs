using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T505
{
    /// <summary>
    /// 反轉陣列
    /// 設計說明：
    ///   1.請用陣列方式寫出反轉陣列的程式，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static string[] score(string[] _x)
        {
            string[] result = new string[_x.Length];
            for (var i = _x.Length-1; i >= 0; i--)
            {
                result[_x.Length - (i+1)] = _x[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] x = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            Console.Write("反轉陣列資料之前:");
            foreach(var i in x)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("反轉陣列資料之後:");
            var y = score(x);
            foreach (var i in y)
            {
                Console.Write($"{i} ");
            }
            Console.Read();
        }
    }
}
