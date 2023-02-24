using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T014
{
    /// 一：基本認識
    /// 單位換算
    /// 設計說明：
    /// 畫面顯示[Please input:]，於後方由鍵盤輸入數字後，輸出轉換數值(由公斤轉換成磅數，
    /// 單位轉換:1公斤等於2.20462磅)，執行結果如範例圖。
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input: ");
            string input = Console.ReadLine();
            double x = 0.0;
            bool result = double.TryParse(input, out x);
            double y = (x * 2.20462);
            Console.Write($"{x} kg={y} ponds");
            Console.Read();
        }
    }
}
