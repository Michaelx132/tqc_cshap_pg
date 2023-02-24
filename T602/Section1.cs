using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T602
{

    /// <summary>
    /// 設計說明：
    ///   1.請撰寫一個LCD類別。10吋的成本是2000元，15吋的成本是2500元，17吋的成本是3000元。
    ///   2.請撰寫一個CPU類別。速度1.66的成本是6000元，速度2.2的成本是8000元，速度2.4的成本是11000元。
    ///   3.請撰寫一個HD類別。120G的成本是2400元，160G的成本是2800元。
    ///   4.請使用以上的零件，撰寫以下的類別。
    ///   5.請撰寫一個MiniNote類別。MiniNote類別的筆電有一個10吋的LCD個速度1.66的CPU及一個120G的HD。
    ///   6.請撰寫一個Note15類別。Note15類別的筆電有一個15吋的LCD、一個速度2.2的CPU及一個160G的HD。
    ///   7.這兩型筆電的成本是其零件成本的1.4倍。定價則是其零件成本的2倍。
    ///   8.請分別製造一個MiniNote筆電及一個Note15筆電，呼叫其getCost方法及getPrice方法、印出其成本及定價的傳回値。
    /// </summary>
    
    public class Unit
    {
        public int cost { set; get; }
        public int Cost()
        {
            return cost;
        }
    }
    public class Lcd : Unit
    {
        public Lcd(int size)
        {
            if (size== 10)
            {
                cost = 2000;
            }else if (size == 15)
            {
                cost = 2500;
            }else if (size == 17)
            {
                cost = 3000;
            }
        }
    }

    public class Cpu : Unit
    {
        public Cpu(double speed)
        {
            if (speed == 1.66)
            {
                cost = 6000;
            }
            else if (speed == 2.2)
            {
                cost = 8000;
            }
            else if (speed == 2.4) {
                cost = 11000;
            }
        }
    }

    public class Hd : Unit
    {

        public Hd(int size)
        {
            if (size == 120)
            {
                cost = 2400;
            }
            else if (size == 160)
            {
                cost = 2800;
            }
        }
    }

    public class NBUnit
    {
        public double _cost { set; get; }
        public double _price { set; get; }

        public double getCost()
        {
            return _cost;
        }
        public double getPrice()
        {
            return _price;
        }

    }

    public class MiniNote : NBUnit
    {
        public MiniNote()
        {
            _cost = (new Lcd(10).Cost() + new Cpu(1.66).Cost() + new Hd(120).Cost()) * 1.4;
            _price = (new Lcd(10).Cost() + new Cpu(1.66).Cost() + new Hd(120).Cost()) * 2.0;
        }
    }

    public class Note15 : NBUnit
    {
        public Note15()
        {
            _cost = (new Lcd(15).Cost() + new Cpu(2.2).Cost() + new Hd(160).Cost()) * 1.4;
            _price = (new Lcd(15).Cost() + new Cpu(2.2).Cost() + new Hd(160).Cost()) * 2;
        }
    }

}
