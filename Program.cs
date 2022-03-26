using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo ob = new SayaTubeVideo("Tutorial Design By Contract - [BASO ARIF]");

            Console.Writeline(ob.playCount);

            ob.IncreasePlayCount(10);

            Console.Writeline(ob.playCount);

            ob.IncreasePlayCount(10);

            Console.Writeline(ob.playCount);

            ob.IncreasePlayCount();

            Console.Writeline(ob.playCount);
        }
    }
}
