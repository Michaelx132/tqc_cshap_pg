using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T010
{
    /// 汽車零件設計
    /// 題目一：
    /// 題目說明：
    ///     請開啟 JPD06_1.java，設計「汽車零件設計」程式。為汽車零件設計一個類
    ///     別架構，請依下列題意完成作答。將 JPD06_1.java 內的 class JPD06_1 修改為
    ///     class JPA06_1，將檔案另存為 JPA06_1.java 後編譯為 JPA06_1.class，所有題
    ///     目中有使用到的類別也請編譯後一併儲存。
    /// 設計說明：
    ///   1.請撰寫一個 Engine（引擎）類別。1600cc 引擎的成本是 20000 元，2000cc
    ///     引擎的成本是 25000 元。請製造一個 1600cc 的引擎及一個 2000cc 的引擎，
    ///     呼叫其 getCost（成本）方法，印出其傳回值。
    ///   2.請撰寫一個 Aircond（空調）類別。Auto 空調的成本是 12000 元，Manual
    ///     空調的成本是 10000 元。請製造一個 Auto 的空調及一個 Manual 的空調，
    ///     呼叫其 getCost（成本）方法，印出其傳回值。
    ///   3.請撰寫一個 Sound（音響）類別。一個音響的成本是 2000 元，請製造一
    /// 個 Sound 物件，呼叫其 getCost（成本）方法，印出其傳回值。
    /// 
    /// 題目二：
    /// 題目說明：
    ///     請開啟 JPD06_2.java，使用第一小題的零件開一家「汽車工廠」。請為這家汽
    ///     車工廠設計一個 Car（汽車）類別架構，以計算車子的成本與售價，請依下列
    ///     題意完成作答。將 JPD06_2.java 內的 class JPD06_2 修改為 class JPA06_2，將
    ///     檔案另存為 JPA06_2.java 後編譯為 JPA06_2.class，所有題目中有使用到的類
    ///     別也請編譯後一併儲存。
    /// 設計說明：
    ///   1.這家汽車工廠生產 BasicCar（基本型）及 LuxCar（豪華車款）兩種汽車。
    ///   2.基本型的成本是：1600cc 引擎成本 + Manual 空調成本 + 5000 元。
    ///   3.豪華車款的成本是：2000cc 引擎成本 + Auto 空調成本 + 10000 元。
    ///   4.這兩型的售價都是成本的 1.2 倍。
    ///   5.分別計算兩款車子的 cost（成本）與 price（售價），顯示如執行結果參考
    ///     畫面。
    ///     
    /// 題目三：
    /// 題目說明：
    ///     請開啟 JPD06_3.java，這家工廠決定增加一「超級豪華型車款」，請依下列題
    ///     意完成作答。將 JPD06_3.java 內的 class JPD06_3 修改為 class JPA06_3，將檔
    ///     案另存為 JPA06_3.java 後編譯為 JPA06_3.class，所有題目中有使用到的類別
    ///     也請編譯後一併儲存。
    /// 設計說明：
    ///   1.SLuxCar（超級豪華型車款）的成本=豪華車款的成本+音響成本。
    ///   2.這型車的售價也是成本的 1.2 倍。請為這型車設計一個 SLuxCar 類別，並
    ///     計算超級豪華型的成本與售價。
    ///   3.也請為這家工廠增加一個方法，此方法能夠比較 SLuxCar（超級豪華型車
    ///     款）是否比 LuxCar（豪華型車款）的售價較貴。
    ///   4.顯示如執行結果參考畫面。
    ///   
    /// 題目四：
    /// 題目說明：
    ///     請開啟 JPD06_4.java，建立一個 Warehouse（倉庫）類別，讀取 data.txt 內，
    ///     將此三台車放入此倉庫中，請依下列題意完成作答。將 JPD06_4.java 內的 class
    ///     JPD06_4 修改為 class JPA06_4 ，將檔案另存為 JPA06_4.java 後編譯為
    ///     JPA06_4.class，所有題目中有使用到的類別也請編譯後一併儲存。
    ///  設計說明：
    ///   1.請建立一個 Warehouse（倉庫）類別，讀取 data.txt 內三台車子的資料，
    ///     每一行即代表一台車，將此三台車放入此倉庫中。
    ///   2.data.txt 內有三筆資料，分別代表 B（Basic 基本款）、L（LuxCar 豪華型車
    ///     款）、S（SLuxCar 超級豪華型車款）的成本，超級豪華車款的成本需再加
    ///     上音響成本，內容如下： 
    ///   3.一個倉庫物件內有一個 ArrayList 物件，這個 ArrayList 可以儲存車子。
    ///   4.請計算這個倉庫內，此三台車的總庫存成本及總售價（成本的 1.2 倍），
    ///     顯示如執行結果參考畫面。
    ///   5.若找不到 data.txt 檔案，則顯示【File not found!】。
    ///   
    /// 題目五：
    /// 題目說明：
    ///     請開啟 JPD06_5.java，請由 wrongdata.txt 讀入車子的資料，然後放入一個由
    ///     Warehouse（倉庫）類別製造的倉庫，請依下列題意完成作答。將 JPD06_5.java
    ///     內的 class JPD06_5 修改為 class JPA06_5，將檔案另存為 JPA06_5.java 後編譯
    ///     為 JPA06_5.class，所有題目中有使用到的類別也請編譯後一併儲存。
    /// 設計說明：
    ///   1.請建立一個倉庫（Warehouse）類別，讀取 wrongdata.txt 內三台車子的資
    ///     料，每一行即代表一台車，將此三台車放入此倉庫中。
    ///   2.wrongdata.txt 內有四筆資料，分別代表 B（Basic 基本款）、L（LuxCar 豪
    ///     華車款）、S（SLuxCar 超級豪華車款）的成本，超級豪華車款的成本需再
    ///     加上音響成本，最後一筆為不正確的資料（沒有 X 款的車型），內容如下：
    ///   3.一個倉庫物件內有一個 ArrayList 物件，這個 ArrayList 可以儲存車子。
    ///   4.wrongdata.txt 有不正確的資料（沒有 X 款的車型），請使用自定例外類別
    ///     處理，將不正確的資料印出。並計算這個倉庫內的總庫存成本及總售價（成
    ///     本的 1.2 倍），顯示如執行結果參考畫面。
    ///   5.若找不到 wrongdata.txt 檔案，則顯示【File not found!】。
    ///
    class Program
    {

        public class SLuxCar : Car
        {
            public SLuxCar(int engine, string air)
            {
                Engine e = new Engine(engine);
                Aircond a = new Aircond(air);
                Sound s = new Sound(1);
                this._cost = e.getCost() + a.getCost() + s.getCost() + 10000;
                this._price = this._cost * 1.2;

            }
            public string expensive(LuxCar lc)
            {
                if (this._price > lc._price)
                {
                    return "Yes!";
                }
                else
                {
                    return "No!";
                }
            }
        }

        static void Main(string[] args)
        {
            //題目一
            Engine e1 = new Engine(1600);
            Console.WriteLine($"{e1._cc} cost:{e1.getCost()}");
            Engine e2 = new Engine(2000);
            Console.WriteLine($"{e2._cc} cost:{e2.getCost()}");
            Aircond g1 = new Aircond("Manual");
            Console.WriteLine($"{g1._air}: {g1.getCost()}");
            Aircond g2 = new Aircond("Auto");
            Console.WriteLine($"{g2._air}: {g2.getCost()}");
            Sound s = new Sound(1);
            Console.WriteLine($"Sound: {s.getCost()}");

            //題目二
            BasicCar bcar = new BasicCar(1600, "Manual");
            Console.WriteLine($"Manual cost:{bcar.cost()}");
            Console.WriteLine($"Manual price:{bcar.price()}");
            LuxCar lcar = new LuxCar(2000, "Auto");
            Console.WriteLine($"Lux cost:{lcar.cost()}");
            Console.WriteLine($"Lux price:{lcar.price()}");

            //題目三
            SLuxCar scar = new SLuxCar(2000, "Auto");
            Console.WriteLine($"SLux cost:{scar.cost()}");
            Console.WriteLine($"SLux price:{scar.price()}");
            Console.Write($"SLuxCar more expensive than LuxCar:{scar.expensive(lcar)}");


            Console.Read();

        }
    }



}
