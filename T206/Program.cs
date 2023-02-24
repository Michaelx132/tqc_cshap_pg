using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T206
{
    /// <summary>
    /// 鍵盤字元判斷
    /// 設計說明：
    ///   1.畫面顯示[Input a character:]，並於下方要求輸入一個英文字母。
    ///   2.若輸入a或b，顯示[You entered a or b]。
    ///   3.若輸入x，顯示[You entered x]；若輸入y，顯示[You entered y]。
    ///   4.若皆非上述英文字母，則顯示[You entered something eles.]。
    ///   5.請使用switch完成編輯中text()的程式，重複五次，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void text()
        {
            Console.Write("Input a character:");
            string input = Console.ReadLine();
            switch (input) { 
                case "a":
                case "b":
                    Console.WriteLine("You entered a or b");
                    break;
                case "x":
                    Console.WriteLine("You entered x");
                    break;
                case "y":
                    Console.WriteLine("You entered y");
                    break;
                default:
                    Console.WriteLine("You entered something eles.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            text();
            text();
            text();
            text();
            text();
            Console.Read();
        }
    }
}
