using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T406
{
    /// <summary>
    /// 尾端遞迴計算總合
    /// 設計說明：
    ///   1.畫面顯示[Input a string of number: ]，並於後方要求輸入一個數字字串。
    ///   2.分別使用尾端遞迴及迴圈計算數字總和，重複執行二次，執行結果如範例圖。
    /// </summary>
    class Program
    {

        static int score_loop(string _x)
        {
            int score = 0;
            int y = 0;
            for(int i = 0; i < _x.Length; i++)
            {
                y = 0;
                int.TryParse(_x.Substring(i,1), out y);
                score += y;
            }
            return score;
        }

        static int score_foo(string _x, int _y, int _score)
        {
            int i = 0;
            if ( _x.Length == _y)
            {
                return _score;
            }
            else
            {
                int.TryParse(_x.Substring(_y,1), out i);
                return score_foo(_x, _y+1, _score+i);
            }
            //return _score;
        }

        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                Console.Write("Input a string of number:");
                string input = Console.ReadLine();
                int score = 0;
                Console.WriteLine($"$迴圈:{score_loop(input)}");
                Console.WriteLine($"$尾端遞迴:{score_foo(input, 0, score)}");

            }
            Console.Read();
        }
    }
}
