using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T306
{
    /// <summary>
    /// 迴圈最大公因數
    /// 設計說明：
    ///   1.畫面顯示[Inout:]，並於下方要求輸入二個整數 m、n，並以空格鍵分隔。
    ///   2.並用一個類別方法及 while loop 計算 m 與 n 的最大公因數，直到輸入m=999為止，
    ///   執行結果如範例圖。
    /// 最大公因數
    /// 將二個數a和b, 
    /// 將 a除b(被除數 a / 除數 b) 求餘數
    /// 將除數改成被除數，而餘數改成除數 求餘數
    /// 最終 餘數為0時，此時除數為最大公因數
    /// 8,12
    /// 8 % 12 = 4
    /// 12 % 4 = 0
    /// 最大公因數 4
    /// </summary>
    class Program
    {
        public static int Score(int m , int n)
        {
            //int val = 0;
            while (n > 0)
            {
                int val = m % n;
                if ( val == 0)
                {
                    break;
                }
                m = n;
                n = val;
            }
            return n;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int m;
                int n;
                Console.WriteLine("Inout:");
                string[] inputs = Console.ReadLine().Split(' ');
                int.TryParse(inputs[0], out m);
                int.TryParse(inputs[1], out n);
                if ( m == 999)
                {
                    break;
                }
                Console.WriteLine($"{Score(m, n)}");
                
            }
            Console.Read();
        }
    }
}
