using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T301
{
    /// <summary>
    /// 巢狀迴圈
    /// 設計說明：
    ///   1.完成程式碼片段，讓count之值為27，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    count++;
                }
            }
            Console.Write($"count= {count}");
            Console.Read();
        }
    }
}
