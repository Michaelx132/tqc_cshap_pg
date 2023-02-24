using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T201
{
    /// <summary>
    /// 公倍數計算
    /// 設計說明：
    ///   1.畫面顯示[Input:]，並於下方要求輸入一個整數。
    ///   2.計算整數是否能同時被5、9整除，若是則印出[Yes]，否則印出[No]，重複二次，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Input:");
                string input = Console.ReadLine();
                int x = 0;
                int.TryParse(input, out x);
                if ( ( x%5 ) == 0  & (x%9) == 0 ){
                    Console.WriteLine($"Yes");
                }else
                {
                    Console.WriteLine($"No");
                }
            }
            Console.Read();
        }
    }
}
