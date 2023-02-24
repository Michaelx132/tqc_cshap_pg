using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T003
{
    /// 文字陣列取出資料
    /// 設計說明：
    ///   1.請撰寫一程式，建立名稱為 weeks 的文字陣列，此文字陣列內容為"Mon", 
    ///     "Tus", "Wed", "Thr", "Fri", "Sat", "Sun"。
    ///   2.讓使用者輸入一個 0-6 之間的整數 n，輸出陣列中的第 n+1 個元素，若輸
    ///     入有誤，請輸出【error】
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "Mon", "Tus", "Wed", "Thr", "Fri", "Sat", "Sun" };
            int n;
            bool result = int.TryParse(Console.ReadLine(),out n);
            if (result & n < strs.Count())
            {
                Console.Write(strs[n]);
            }
            else
            {
                Console.Write("error");
            }

            Console.Read();

        }
    }
}
