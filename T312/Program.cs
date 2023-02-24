using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T312
{
    /// <summary>
    /// 設計說明：
    ///   1.請使用者輸入5組數字，input 1: .. input 5:
    ///   2.依先進先出 FIFO顯示
    ///   3.依後進先出 LIFO昺示
    ///   https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/concepts/collections
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Queue<int> a1 = new Queue<int>();
            Stack<int> a2 = new Stack<int>();
            for(var i= 1; i <=5 ; i++)
            {
                Console.Write($"Input {i}:");
                var r = int.TryParse(Console.ReadLine(), out x);
                if (r)
                {
                    a1.Enqueue(x);
                    a2.Push(x);
                }
            }

            foreach(var item in a1)
            {
                Console.WriteLine($"Queue:{item}");
            }

            foreach (var item in a2)
            {
                Console.WriteLine($"Stact:{item}");
            }

            Console.Read();
        }
    }
}
