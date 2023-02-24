using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T507
{
    /// <summary>
    /// 停車費用計算
    /// 設計說明：
    ///   1.假設停車時段分為：
    ///     a.2小時內(含2小時)，每小時以30元計算。
    ///     b.2小時以上不足4小時，每小時以50元計算。    
    ///     c.4小時以上不足6小時，每小時以80元計算。
    ///     d.6小時以上，每小時以1000元計算。
    ///   2.使用陣列的方式寫出停車費計算的程式，執行結果如範例圖。
    /// </summary>
    class Program
    {
        static void score(int hr)
        {
            int result = 0;
            int[] hrs = { 30,50,80,100 };
            for (var g = 1; g <= hr; g++)
            {
                if (g > 6)
                {
                    result += hrs[3];
                }
                else
                {
                    if (g > 4)
                    {
                        result += hrs[2];
                    }
                    else
                    {
                        if (g > 2)
                        {
                            result += hrs[1];
                        }
                        else
                        {
                            result += hrs[0];
                        }

                    }
                }

                
            }
            Console.WriteLine($"停車時數:{hr}");
            Console.WriteLine($"停車費用:{result}");
            Console.WriteLine("-------------------");
        }

        static void Main(string[] args)
        {
            score(2);
            score(3);
            score(5);
            score(8);
            Console.Read();
        }
    }
}
