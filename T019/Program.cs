using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T019
{
    /// <summary>
    /// 二. 條件判斷式
    /// 比較大小
    /// 設計說明：
    ///  1.於面顯示[Input:]，並於下方要求輸入兩個整數，中間以空格分開。
    ///  2.依輸入的兩個整數比較大小，重複二次，執行結果如範例圖。
    ///  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<2; i++)
            {
                int x = 0;
                int y = 0;
                Console.WriteLine("Input:");
                string[] input = Console.ReadLine().Split(' ');
                int.TryParse(input[0], out x);
                int.TryParse(input[1], out y);
                if (x > y)
                {
                    Console.WriteLine($"{x} is larger than {y}");
                }
                else if (y > x)
                {
                    Console.WriteLine($"{y} is larger than {x}");
                }
                else
                {
                    Console.WriteLine($"{x} and {y} are equal.");
                }

            }

            Console.Read();
        }
    }
}
