using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T304
{
    /// <summary>
    /// 迴圈接成計算
    /// 設計說明：
    ///   1.畫面顯示[Please enter value:]，並於後方要求輸入一個整數。
    ///   2.如果輸入的數是介於1 ~10，則輸出階乘計算後的值，否則輸出[Error, the value is out of range.]
    ///     ，重複執行三次，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                int x = 0;
                Console.Write("Please enter value:");
                string input = Console.ReadLine();
                bool is_int = int.TryParse(input, out x);
                int total = 1;
                if (is_int)
                {
                    if (x > 0 & x <= 10)
                    {
                        for(int y = 1; y <= x; y++)
                        {
                            total *= y; 
                        }
                        Console.WriteLine($"{x}!: {total}");
                    }
                    else
                    {
                        Console.WriteLine("Error, the value is out of range.");
                    }
                }
                else
                {
                    Console.WriteLine("Error.");
                }

            }
            Console.Read();
        }
    }
}
