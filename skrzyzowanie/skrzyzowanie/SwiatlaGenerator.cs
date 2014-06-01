using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class SwiatlaGenerator {
        private static int seedValue = 123123123 + Environment.TickCount;
        private static bool[] lastOccured = { false, false, false, false, false, false, false, false, false, false, false, false};

        public bool[] generateBasingOnPrevious(bool[] data)
        {
            bool[] values = new bool[data.Length];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = ( data[i] ? randomize() : false );
            }

            return values;
        }

        public bool[] generateNextVec(int length) {
            List<bool> vec = new List<bool>();

            for(int i = 0 ; i < length ; i++ ) {
                vec.Add(randomize());
            }
            
            return vec.ToArray();
        }

        private bool randomize() {
            Random radom = new Random(seedValue);
            seedValue = radom.Next();

            return Convert.ToBoolean(seedValue % 2);
        }

        public static String test() {
            StringBuilder builder = new StringBuilder();
            SwiatlaGenerator sw = new SwiatlaGenerator();

            bool[] generatedVec = sw.generateNextVec(12);

            foreach (bool var in generatedVec)
            {
                builder.Append(var + " | ");
            }

            return builder.ToString();
        }
    }
}
