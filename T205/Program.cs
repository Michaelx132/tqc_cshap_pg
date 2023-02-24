using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T205
{
    /// <summary>
    /// 象限座標
    /// 設計說明：
    ///   1.畫面顯示[請輸入x座標：]，並於後方要求輸入x座標，在要求輸入y座標。
    ///   2.輸出座標在哪個象限上，若在x軸上則輸出[座標直+在x軸上]，y軸同理，
    ///     若在第一象限則輸出[標直+在第一象限]，二、三、四象限同理。
    ///   3.重複四次，執行結果如範例圖。
    /// 象限說明：
    ///               X Y
    /// 第一象限    （+,+）
    /// 第二象限    （-,+）
    /// 第三象限    （-,-）
    /// 第四象限    （+,-）
    /// 
    ///  2│1
    /// ─┼─
    ///  3│4
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 4; i++)
            {
                double x = 0;
                double y = 0;
                Console.Write("請輸入x座標：");
                string input_x = Console.ReadLine();
                Console.Write("請輸入y座標：");
                string input_y = Console.ReadLine();
                double.TryParse(input_x, out x);
                double.TryParse(input_y, out y);
                if (x == 0)
                {
                    Console.WriteLine($"{x},{y}座標在y軸上");
                }else if (y == 0)
                {
                    Console.WriteLine($"{x},{y}座標在x軸上");
                }
                else
                {
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            Console.WriteLine($"{x},{y}座標在第一象限");
                        }
                        else {
                            Console.WriteLine($"{x},{y}座標在第四象限");
                        }
                    }
                    else
                    {
                        if (y > 0)
                        {
                            Console.WriteLine($"{x},{y}座標在第二象限");
                        }
                        else
                        {
                            Console.WriteLine($"{x},{y}座標在第三象限");
                        }

                    }
                }


            }
            Console.Read();
        }
    }
}
