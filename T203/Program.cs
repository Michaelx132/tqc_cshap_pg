using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T203
{
    /// <summary>
    /// 及格分數
    /// 設計說明：
    ///   1.畫面顯示[Input Chinese score:]，並於後方要求輸入國文分數，
    ///     再分別要求輸入英文、數學分數。
    ///   2.如果任何一科不及格，則分別顯示[科目+failed.]，如果全部都及格則顯示[All Pass.]，
    ///     重複四次，執行結果如範例圖。
    ///   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 4; i++)
            {
                int x1 = 0;
                int x2 = 0;
                int x3 = 0;
                Console.Write("Input Chinese score:");
                string input1 = Console.ReadLine();
                Console.Write("Input English score:");
                string input2 = Console.ReadLine();
                Console.Write("Input Math score:");
                string input3 = Console.ReadLine();
                int.TryParse(input1, out x1);
                if (x1 < 60)
                {
                    Console.WriteLine($"國文 failed.");
                }
                int.TryParse(input2, out x2);
                if (x2 < 60)
                {
                    Console.WriteLine($"英文 failed.");
                }
                int.TryParse(input3, out x3);
                if (x3 < 60)
                {
                    Console.WriteLine($"數學 failed.");
                }
                if ( (x1>=60) & (x2 >= 60) & (x3 >= 60))
                {
                    Console.WriteLine("All pass");
                }


            }
            Console.Read();
        }
    }
}
