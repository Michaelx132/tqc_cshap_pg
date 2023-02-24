using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T509
{
    /// <summary>
    /// 選擇排序法
    /// 設計說明：
    ///   1.使用選擇排序法(Selection Sort)撰寫程式。
    ///   2.請輸出選擇排序法的排序過程，執行結果如範例圖。
    /// 選擇排序法
    ///     檢查數列中，每一回合找出最小小值與第一個元素對調，
    ///     例:
    ///     3 2 8 1
    ///     1 2 8 3
    ///     1 2 8 3
    ///     1 2 3 8
    ///     
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("遞迴寫法");
            T509A t509a = new T509A();
            Console.WriteLine("迴圈寫法");
            T509B t509b = new T509B();

            Console.Read();
        }
    }
}
