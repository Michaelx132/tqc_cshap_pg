using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T010
{
    public class Car
    {
        public double _cost { set; get; }
        public double _price { set; get; }
        public Car()
        {
            this._cost = 0;
            this._price = 0;
        }
        public double cost()
        {
            return this._cost;
        }
        public double price()
        {
            return this._price;
        }
    }

    public class BasicCar : Car
    {
        public BasicCar(int engine, string air)
        {
            Engine e = new Engine(engine);
            Aircond a = new Aircond(air);
            this._cost = e.getCost() + a.getCost() + 5000;
            this._price = (this._cost * 1.2);
        }
    }

    public class LuxCar : Car
    {
        public LuxCar(int engine, string air)
        {
            Engine e = new Engine(engine);
            Aircond a = new Aircond(air);
            this._cost = e.getCost() + a.getCost() + 10000;
            this._price = (this._cost * 1.2);

        }
    }
}
