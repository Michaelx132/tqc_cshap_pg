using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T509
{
    public class T509A
    {

        public void score_foo(int[] _x, int _y)
        {
            if (_y < _x.Length-1)
            {
                int tmp;
                int idx = 0;
                for (var i = _y; i < _x.Length; i++)
                {
                    if (_x[_y] > _x[i])
                    {
                        idx = i;
                    }
                    else
                    {
                        idx = _y;
                    }
                }
                tmp = _x[_y];
                _x[_y] = _x[idx];
                _x[idx] = tmp;

                foreach (var v in _x)
                {
                    Console.Write($"{v} ");
                }
                Console.WriteLine();
                score_foo(_x, _y + 1);
            }
        }
        public T509A()
        {
            int[] vals = { 1, 2, 3, 4, 5, 6 };
            /*
            foreach (var v in vals)
            {
                Console.Write($"{v} ");
            }
            */            
            score_foo(vals,0);
        }
    }
}
