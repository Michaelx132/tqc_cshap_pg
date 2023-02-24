using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T602
{
    /// <summary>
    /// 設計說明：
    ///   1.請比較一台Note 15的筆電和一個PC類別的桌上型電腦何者售價較貴。
    ///   2.請新增一個名為AllPC的類別，於此類別中撰寫isExpensive方法，
    ///     此方法龍夠比較何者的售價較貴，並傳回一個布林值，顯示如執行結果參考畫面。
    ///   
    /// </summary>
    public class AllPC
    {
        public double a { set; get; }
        public double b { set; get; }
        public AllPC(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        public bool isExpensive()
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
