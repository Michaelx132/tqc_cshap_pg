using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T602
{

    class Program
    {
        static void Main(string[] args)
        {
            // Section 1
            MiniNote nb1 = new MiniNote();
            Console.WriteLine($"MiniNote cost:{nb1.getCost()}, price:{nb1.getPrice()}");
            Note15 nb2 = new Note15();
            Console.WriteLine($"Note15 cost:{nb2.getCost()}, price:{nb2.getPrice()}");

            // Section 2
            PC pc1 = new PC();
            Console.WriteLine($"PC cost:{pc1.getCost()}, price:{pc1.getPrice()}");
            MultiPC pc2 = new MultiPC(2, 4);
            Console.WriteLine($"MultiPC 2cpu 4hd cost:{pc2.getCost()}, price:{pc2.getPrice()}");
            MultiPC pc3 = new MultiPC(4, 8);
            Console.WriteLine($"MultiPC 4cpu 8hd cost:{pc3.getCost()}, price:{pc3.getPrice()}");


            // Section 3
            AllPC allPc = new AllPC(new Note15().getPrice(), new PC().getPrice());
            if (allPc.isExpensive())
            {
                Console.WriteLine("Note15 is more expensive than PC");
            }
            else
            {
                Console.WriteLine("PC is more expensive than Note15");
            }

            Order odr = new Order();
            odr.In(new MiniNote());
            odr.In(new Note15());
            odr.In(new PC());
            Console.WriteLine($"Total: { odr.revenue()}");

            Order2 odr2 = new Order2();
            odr2.In(new MiniNote());
            odr2.In(new Note15());
            odr2.In(new PC());
            Console.WriteLine($"This order exceeds 20000: {odr2.GetMoney()}");
            


            Console.Read();
        }
    }
}
