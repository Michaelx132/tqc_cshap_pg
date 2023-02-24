using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T005
{
    /// 一：基本認識
    /// 計算平均值
    /// 設計說明：
    ///   1.畫面顯示[Please input:]，於下方由鍵盤輸入3個整數，個整數中間以空隔間格，並分別存入3個整數變數。
    ///   2.計算這3個整數的平均值，平均值取到小數第二位並輸出。
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prease Input:");
            string input_str = Console.ReadLine();
            string[] inputs = input_str.Split(' ');
            int s = 0;
            foreach (var i in inputs) {
                int z = 0;
                bool result = int.TryParse(i, out z);
                if (result)
                {
                    s += z;
                }
            }
            float avgval = (s / (float)inputs.Count());
            Console.Write($"Average:{ Math.Round(avgval,2)}");
            Console.Read();


        }
    }
}
