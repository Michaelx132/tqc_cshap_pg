using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T204
{
    /// <summary>
    ///  分級制度
    ///  設計說明：
    ///    1.畫面顯示[Input:]，並於下方要求輸入一個分數。
    ///    2.當分數大於等於90分，等極為A，顯示[Your grade is A]。
    ///    3.當分數小於90分並大於等於80分，等及為B，顯示[Your grade is B]。
    ///    4.當分數小於80分並大於等於70分，等及為C，顯示[Your grade is C]。
    ///    5.當分數小於70分並大於等於60分，等及為D，顯示[Your grade is D]。
    ///    6.當分數小於60分，等及為F，顯示[Your grade is F]。
    ///    7.重複五次，執行結果如範例圖。
    ///    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input:");
                int x = 0;
                string input = Console.ReadLine();
                int.TryParse(input, out x);
                if (x >= 90)
                {
                    Console.WriteLine($"Your grade is A");
                }
                else if (x >= 80)
                {
                    Console.WriteLine($"Your grade is B");
                }
                else if (x >= 70)
                {
                    Console.WriteLine($"Your grade is C");
                }
                else if (x >= 60)
                {
                    Console.WriteLine($"Your grade is D");
                }
                else
                {
                    Console.WriteLine($"Your grade is F");
                }
            }
            Console.Read();
        }
    }
}
