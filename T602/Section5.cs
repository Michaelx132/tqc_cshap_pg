using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T602
{
    /// <summary>
    /// 設計說明：
    ///   1.此筆訂單的資料如下：MineNote 1台、Note15 1台、PC 1台。
    ///   2.利潤=總收入-總成本(非零件總成本)。
    ///   3.如果此次收入淨額超過20000，則印出訊息[This order exceeds 20000:收入淨額]。
    ///   
    /// </summary>
    public class Order2 : Order
    {
        public List<NBUnit> order { set; get; }
        public Order2()
        {
            order = new List<NBUnit>();
        }

        public void In(NBUnit s)
        {
            order.Add(s);
        }

        public double GetMoney()
        {
            double result = 0;
            foreach(var item in order)
            {
                result += item.getPrice() - item.getCost();
            }
            return result;
        }

    }
}
