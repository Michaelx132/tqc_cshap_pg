using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T012
{
    /// 汽車外觀設計
    /// 設計說明：
    ///   1.專案已內含名為 car 的類別，內含 cc 屬性，請建立 int 型態的 seats、color、
    ///     doors 屬性，其中 color 屬性請使用列舉，RED=1、BLUE=2、WHITE=3。
    ///   2.於Main()中撰寫程式，讓使用者依序輸入以半形空格隔開的車子的cc數、
    ///     座位數量、顏色及車門數量。
    ///   3.輸出格式為【新車各項屬性：${車子 cc 數}cc${座位數量}${顏色}${車門數量}】，
    ///     輸出字串中無任何空格，如：【1500cc4RED4】，
    ///     若輸入不在規定範圍的顏色，請輸出【error】。
    ///     ＊ 提示：${名稱} 用來表示該名稱的變數，如：${ 車子 cc 數}= 1500。
    ///     

    public enum COLORS
    {
        RED = 1,
        BLUE = 2,
        WHITE = 3

    }

    public class Car
    {
        public string cc { set; get; }
    }

    public class NewCar : Car
    {
        public int seats { set; get; }
        public int color { set; get; }
        public int doors { set; get; }

        public NewCar(string input)
        {
            int z = 0;
            string[] tmp = input.Split(' ');
            this.cc = tmp[0];
            int.TryParse(tmp[1],out z);
            this.seats = z;
            z = 0;
            int.TryParse(tmp[2], out z);
            this.color = z;
            z = 0;
            int.TryParse(tmp[3], out z);
            this.doors = z;
        }

        public string info()
        {
            return $"新車各項屬性：{this.cc}cc{this.seats}{(COLORS)this.color}{this.doors}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NewCar ncar = new NewCar(input);
            Console.Write(ncar.info());
            Console.Read();


        }
    }
}
