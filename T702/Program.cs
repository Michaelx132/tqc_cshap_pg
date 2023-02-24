using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T702
{
    /// <summary>
    /// 設計說明：
    ///   1.請撰寫程式，讓使用者輸入任意資料（單行），輸出使用者的輸入內容並利用 Stream
    ///     寫入至 write.txt 檔案中，每一次皆覆蓋上一次的資料，若輸入空值，請
    ///     輸出【error】，不進行資料寫入。
    ///   2.請使用 Stream方法，從 write.txt 中讀出檔案內容並輸出【write:xxx】。

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string path = System.Environment.CurrentDirectory;
            if (!string.IsNullOrWhiteSpace(input))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, $"write.txt")))
                {
                    sw.WriteLine(input);
                    sw.Close();
                }
                Console.WriteLine($"{input}");
            }
            else
            {
                Console.WriteLine($"error");
            }

            using (StreamReader sr = new StreamReader(Path.Combine(path,$"write.txt")))
            {
                Console.WriteLine($"write.txt:{sr.ReadLine()}");
                sr.Close();

            }

                Console.Read();

        }
    }
}
