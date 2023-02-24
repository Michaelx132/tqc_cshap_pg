using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T602
{

    /// <summary>
    /// 設計說明：
    ///   1.請寫一個PC類別，一個PC類別的桌上型電腦有一個速度2.4的CPU及一個160G的HD。
    ///     製造一個PC類別的桌上型電腦的成本是「零件成本」加500、售價則為「零件成本」的1.8倍。
    ///   2.另請寫一個MultiPC類別，一個MultiPC的超級電腦，可以有多顆2.4G的CPU及多顆160G的HD。
    ///     MultiPC的成本為其「零件成本」的1.2倍，售價為其「零件成本」的1.8倍。
    ///   3.請製造一個PC類別的桌上型電腦，一個2顆CPU及4顆HD的MultiPC及一個4顆CPU及8顆HD的MultiPC。
    ///   4.分別呼叫其getCost方法及getPrice方法，印出其傳回值。
    ///   
    /// </summary>
    public class PC : NBUnit
    {
        public PC()
        {
            _cost = (new Cpu(2.4).Cost() + new Hd(160).Cost()) + 500;
            _price = (new Cpu(2.4).Cost() + new Hd(160).Cost()) * 1.8;
        }
    }

    public class MultiPC : NBUnit
    {
        public MultiPC(int cpu,int hd)
        {
            _cost = (new Cpu(2.4).Cost()*cpu + new Hd(160).Cost()*hd )  * 1.2;
            _price = (new Cpu(2.4).Cost() * cpu + new Hd(160).Cost() * hd) * 1.8;
        }
    }


}
