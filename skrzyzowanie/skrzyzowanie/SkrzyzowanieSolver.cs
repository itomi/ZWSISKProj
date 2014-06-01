using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class SkrzyzowanieSolver
    {
        public SolverProcess solveSkrzyzowanie(Skrzyzowanie skrzyzowanie) {
            int lightChanges = 0;
            SwiatlaGenerator sw = new SwiatlaGenerator();
            Walidator walidator = new Walidator();
            SolverProcess process = new SolverProcess(skrzyzowanie);
            while (!skrzyzowanie.isEmpty()) {
                bool[] nextSwiatlaState = sw.generateNextVec(12);

                while (!walidator.walidacja(nextSwiatlaState)) {
                    nextSwiatlaState = sw.generateNextVec(12);
                }
                Tuple<int,int,int> modificationValues = skrzyzowanie.modifyState(nextSwiatlaState);
                process.addStep(new SolverStep(nextSwiatlaState, modificationValues));
                
                lightChanges++;
            }
            return process;
        }
    }
}
