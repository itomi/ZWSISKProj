using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class SkrzyzowanieSolver
    {
        public int solveSkrzyzowanie(Skrzyzowanie skrzyzowanie) {
            int lightChanges = 0;
            SwiatlaGenerator sw = new SwiatlaGenerator();
            Walidator walidator = new Walidator();
            while (!skrzyzowanie.isEmpty())
            {
                bool[] nextSwiatlaState = sw.generateNextVec(12);

                while (!walidator.walidacja(nextSwiatlaState))
                {
                    nextSwiatlaState = sw.generateNextVec(12);
                }
                skrzyzowanie.modifyState(nextSwiatlaState);
                
                lightChanges++;
            }
            return lightChanges;
        }
    }
}
