using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class SkrzyzowanieSolver
    {
        bool[] wektor = new bool[12];

        public SkrzyzowanieSolver()
        {
            for (int i = 0; i<wektor.Length; i++)
            {
                wektor[i] = true;
            }
        }

        bool[] wywalNiepotrzebneOtware(bool [] wejsciowy)
        {
            for (int i = 0; i<this.wektor.Length; i++)
            {
                if (!this.wektor[i])
                {
                    wejsciowy[i] = false;
                }
            }
            return wejsciowy;
        }

        void zmienWektor(bool[] wejsciowy)
        {
            for (int i = 0; i < this.wektor.Length; i++)
            {
                if (wejsciowy[i])
                {
                    this.wektor[i] = false;
                }
            }
        }

        public SolverProcess solveSkrzyzowanie(Skrzyzowanie skrzyzowanie)
        {
            int lightChanges = 0;
            SwiatlaGenerator sw = new SwiatlaGenerator();
            Walidator walidator = new Walidator();
            SolverProcess process = new SolverProcess(skrzyzowanie);
            for (int i = 0; i < wektor.Length; i++)
            {
                wektor[i] = true;
            }
            while (!skrzyzowanie.isEmpty()) {
                bool[] nextSwiatlaState = sw.generateNextVec(12);

//              nextSwiatlaState = wywalNiepotrzebneOtware(nextSwiatlaState);

               while (!walidator.walidacja(nextSwiatlaState)) {
                    nextSwiatlaState = sw.generateBasingOnPrevious(wektor);
//                    nextSwiatlaState = wywalNiepotrzebneOtware(nextSwiatlaState);
                }
              
                Tuple<int,int,int> modificationValues = skrzyzowanie.modifyState(nextSwiatlaState);
                process.addStep(new SolverStep(nextSwiatlaState, modificationValues));
                
                lightChanges++;
                zmienWektor(nextSwiatlaState);
            }
            return process;
        }
    }
}
