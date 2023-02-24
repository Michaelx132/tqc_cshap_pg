using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T015
{
    class Program
    {
        /// <summary>
        /// 一：基本認識
        /// 距離計算
        /// 設計說明：
        /// 1. Math套件(package)內有許多數學上常用的函數。
        /// 2. 請使用 Math.pow 及 Math.sqrt 撰寫程式，顯示[請輸入第1組的x和y座標:]，在後方輸入左標(x1, y1)，
        ///    x與y座標以一空格分隔，資料型態皆為正整數。
        /// 3. 要求輸入第二組座標(x2, y2)，並輸出兩組座標之間的距離，執行結果如範例圖。
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("請輸入第1組的x和y座標:");
            string input_x = Console.ReadLine();
            Console.Write("請輸入第2組的x2和y2座標:");
            string input_y = Console.ReadLine();
            string[] tmp_x = input_x.Split(' ');
            string[] tmp_y = input_y.Split(' ');
            int x1, x2, y1, y2 = 0;
            int.TryParse(tmp_x[0], out x1);
            int.TryParse(tmp_x[1], out x2);
            int.TryParse(tmp_y[0], out y1);
            int.TryParse(tmp_y[1], out y2);

            double x = Math.Sqrt( Math.Pow((x1-x2),2) + Math.Pow( (y1-y2),2 )  );
            Console.Write($"介於({x1*1.0},{y1*1.0})和({x2*1.0},{y2*1.0})之間的距離是{x}");

            Console.Read();
        }
    }
}
