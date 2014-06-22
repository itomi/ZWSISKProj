using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skrzyzowanie
{
    class Lotto
    {
        private static int seedValue = 123123123 + Environment.TickCount;
        public static Random radom; 

        public static void seeduj() {
            radom = new Random(seedValue);
        }

        public bool randomize()
        {
            //Random radom = new Random(seedValue);
            seedValue = radom.Next();

            return Convert.ToBoolean(seedValue % 2);
        }
    }
}
