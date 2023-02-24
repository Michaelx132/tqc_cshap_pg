using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T509
{
    public class T509B
    {
        public void score_for(int[] _x)
        {
            int min;
            int d;
            for(var i = 0; i < _x.Length-1; i++)
            {
                min = i;
                for(var j= i+1; j < _x.Length; j++)
                {
                    if (_x[min] > _x[j])
                    {
                        min = j;
                    }
                }
                d = _x[min];
                _x[min] = _x[i];
                _x[i] = d;
                foreach( var v in _x)
                {
                    Console.Write($"{v} ");
                }
                Console.WriteLine();
            }
        }

        public T509B()
        {
            int[] vals = { 1, 2, 3, 4, 5, 6 };
            score_for(vals);

        }
    }
}
