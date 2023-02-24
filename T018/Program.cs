using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T018
{
    /// <summary>
    /// 一.基本認識
    /// 運動成績
    /// 設計說明：
    ///   1.本題使用其他類別定義的類別方法。
    ///   2.假設老師在計算運動成績的分數時，動作佔1分，技巧佔2分，隊表現佔3分。
    ///   3.basketball 的分數計算方式為:動作(action)+技巧(skill)+團隊表現(teamgame); baseball的分數計算
    ///     方式為:10+技巧(skill)+團隊表現(teamgame)。
    ///   4.程式內已提供 basketball 與 baseball 兩個類別及成績計算方式，他們各有一個calGrade方法，請將
    ///     此方法分別補上。
    ///   5.程式執行時直接計算成績並輸出，執行結果如範例圖。
    ///   
    /// </summary>
    /// 
    public class basketball {
        public int calGrad(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    public class baseball {
        public int calGrad(int b, int c) {
            return 10 + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int action = 1;
            int skill = 2;
            int teamgame = 3;
            basketball b1 = new basketball();
            Console.WriteLine($"The basketball grade is {b1.calGrad(action, skill, teamgame)}");
            baseball b2 = new baseball();
            Console.WriteLine($"The baseball grade is {b2.calGrad(skill, teamgame)}");
            Console.Read();
        }
    }
}
