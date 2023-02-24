using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T409
{
    /// <summary>
    /// 遞迴字串轉換
    /// 設計說明：
    ///   1.畫面顯示[Input a string: ]，並於後方要求輸入一個字串。
    ///   2.畫面顯示[Input a character: ]，並於後方要求輸入一個欲替換字元。
    ///   3.畫面顯示[Input another character: ]，並於後方要求輸入一個被替換字元。
    ///   4.使用遞迴將字串裡的欲替換字元替換，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static string score_foo(string _a,string _b,string _c,int _y, string _score)
        {
            if (_a.Length == _y)
            {
                return _score;
            }
            else
            {
                if (_a.Substring(_y,1) == _b)
                {
                    _score += _c;
                }
                else
                {
                    _score += _a.Substring(_y, 1);
                }
                return score_foo(_a, _b, _c, _y+1, _score);
            }
        }
        static void Main(string[] args)
        {
            string score = string.Empty;
            Console.Write("Input a string: ");
            string input_a = Console.ReadLine();
            Console.Write("Input a character: ");
            string input_b = Console.ReadLine();
            Console.Write("Input another character: ");
            string input_c = Console.ReadLine();
            Console.WriteLine($"{score_foo(input_a,input_b,input_c,0,score)}");
            Console.Read();
        }
    }
}
