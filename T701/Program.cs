using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T701
{
    class Program
    {
        /// <summary>
        /// 設計說明：
        ///   1.請撰寫程式，讓使用者輸入任意資料（單行），輸出使用者的輸入內容並
        ///     寫入至 write.txt 檔案中，每一次皆覆蓋上一次的資料，若輸入空值，請
        ///     輸出【error】，不進行資料寫入。
        ///   2.請使用 print()方法，從 write.txt 中讀出檔案內容並輸出【write:xxx】。
        ///   
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = System.Environment.CurrentDirectory;
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"error");
            }
            else
            {
                Console.WriteLine(input);
                File.WriteAllText(Path.Combine(path, $"write.txt"), input);
            }

            string txt = File.ReadAllText(Path.Combine(path, $"write.txt"));
            Console.WriteLine($"write: {txt}");
            Console.Read();

        }
    }
}
