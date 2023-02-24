using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T010
{
    public class CarUnit
    {
        public int _cost { set; get; }
        public CarUnit()
        {
            _cost = 0;
        }

        public int getCost()
        {
            return _cost;
        }
    }

    public class Engine : CarUnit
    {
        public int _cc { get; set; } 
        public Engine(int cc)
        {
            this._cc = cc;

            if (cc == 1600)
            {
                this._cost = 20000;
            }
            if (cc == 2000)
            {
                this._cost = 25000;
            }
        }
    }

    public class Aircond : CarUnit
    {
        public string _air { set; get; }
        public Aircond(string air)
        {
            this._air = air;
            if (air == "Manual")
            {
                base._cost = 10000;
            }
            if (air == "Auto")
            {
                base._cost = 12000;
            }
        }
    }

    public class Sound : CarUnit
    {
        public Sound(int i)
        {
            base._cost = 2000 * i;
        }
    }
}
