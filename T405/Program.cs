using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T405
{
    /// <summary>
    /// 遞迴字串計算
    /// 設計說明：
    ///   1.畫面顯示[Input a string: ]，並於後方要求輸入一個字串。
    ///   2.使用遞迴計算字串內有幾個"A"，重複執行二次，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static int foo(string _x,int _y,int total)
        {
            if (_y == _x.Length)
            {
                return total;
            }
            else
            {
                if (_x.Substring(_y,1)== "A")
                {
                    total++;
                }
                return foo(_x,_y+1,total);
            }

        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                int total = 0;
                Console.Write("Input a string:");
                string input = Console.ReadLine();
                Console.WriteLine($"{input} has { foo(input,0, total)}s");

            }
            Console.Read();
        }
    }
}
