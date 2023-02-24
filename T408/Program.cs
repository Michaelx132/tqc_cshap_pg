using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T408
{
    /// <summary>
    /// 遞迴字串移除
    /// 設計說明：
    ///   1.畫面顯示[Input a string: ]，並於後方要求輸入一個字串。
    ///   2.畫面顯示[Input a character: ]，並於後方要求輸入一個欲移除字元。
    ///   3.使用遞迴將字串裡的欲移除字元移除，重複執行二次，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static string score_foo(string _x,int _y, string _char, string _score)
        {
            if ( _x.Length == _y)
            {
                return _score;
            }
            else
            {
                if ( _x.Substring(_y,1) != _char)
                {
                    _score += _x.Substring(_y, 1);
                }
                return score_foo(_x, _y+1, _char, _score);
            }
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                string score = string.Empty;
                Console.Write("Input a string:");
                string input = Console.ReadLine();
                Console.Write("Input a character:");
                string input_char = Console.ReadLine();
                Console.WriteLine($"{ score_foo(input,0,input_char,score) }");

            }
            Console.Read();
        }
    }
}
