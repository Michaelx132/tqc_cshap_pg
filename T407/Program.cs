using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T407
{
    /// <summary>
    /// 遞迴字串反向
    ///   1.畫面顯示[Input a string: ]，並於後方要求輸入一個字串。
    ///   2.使用遞迴方法將此字串反向，重複執行二次，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static string score_foo(string _x,int _y, string _score)
        {
            if (_x.Length == _y)
            {
                return _score;
            }
            else
            {
                return score_foo(_x, _y+1, _x.Substring(_y,1)+ _score);
            }
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                string score = string.Empty;
                Console.Write("Input a string:");
                string input = Console.ReadLine();
                Console.WriteLine($"{score_foo(input, 0, score)}");
            }
            Console.Read();
        }
    }
}
