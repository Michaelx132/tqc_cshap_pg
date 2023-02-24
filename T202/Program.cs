using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T202
{
    /// <summary>
    /// 倍數判斷
    /// 設計說明：
    ///   1.畫面顯示[Enter an integer:]，並於下方要求輸入一個整數。
    ///   2.若輸入的整數是2、3或6的倍數，請輸出此整數是2、3、6哪些的倍數，
    ///     否則則輸出[xx 不是2、3、6的倍數]，xx為輸入的整數，重複四次，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter an integer:");
                string input = Console.ReadLine();
                int x = 0;
                int.TryParse(input, out x);
                if ((x % 6) == 0)
                {
                    Console.WriteLine($"{x}是2、3、6的倍數");
                }
                else if ((x % 2) == 0) {
                    Console.WriteLine($"{x}是2的倍數");
                }
                else if ((x % 3) == 0)
                {
                    Console.WriteLine($"{x}是3的倍數");
                }
                else
                {
                    Console.WriteLine($"{x}不是2、3、6的倍數");
                }
            }
            Console.Read();
        }
    }
}
