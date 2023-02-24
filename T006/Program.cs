using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T006
{
    /// 分數篩選
    /// 設計說明：
    ///   1.請設計一程式，此程式能判斷輸入分數是否及格，程式執行時，顯示【Please
    ///     enter score:】要求輸入分數。
    ///   2.如果使用者輸入的分數大於等於 60，則輸出【You pass】。
    ///   3.如果使用者的分數小於 60，則不做任何處理。
    ///   4.最後由電腦輸出【End】代表程式結束。
    ///   5.重複執行兩次，顯示如執行結果參考畫面。
    ///   
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter score:");
            string input = Console.ReadLine();
            float score = 0;
            bool result = float.TryParse(input, out score);
            if (result)
            {
                if (score >= 60)
                {
                    Console.WriteLine("You pass");
                }
                Console.Write("End");
            }
            Console.Read();
        }
    }
}
