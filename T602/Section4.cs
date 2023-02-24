using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T602
{
    /// <summary>
    /// 設計說明：
    ///   1.請使用List為這家工廠寫一個Order類別。
    ///   2.此筆訂單的資料如下：MiniNote 1台、Note15 1台、PC 1台。
    ///   3.請寫一個revenue方法，輸出此訂單的總收入。
    /// </summary>
    public class Order
    {
        public List<NBUnit> order { set; get; }
        public Order()
        {
            order = new List<NBUnit>();
        }

        public void In(NBUnit s)
        {
            order.Add(s);
        }

        public double revenue()
        {
            double total = 0;
            foreach(var item in order)
            {
                total += item.getPrice();
            }
            return total;
        }
    }
}
