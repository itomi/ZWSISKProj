using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class SolverStep
    {
        bool[] swiatlaState;
        Tuple<int,int,int> maxAndSumPassedCars;

        public SolverStep(bool[] swiatlaState, Tuple<int,int,int> max)
        {
            this.swiatlaState = swiatlaState;
            this.maxAndSumPassedCars = max;
        }

        public bool[] getSwiatlaState()
        {
            return this.swiatlaState;
        }

        public int getCarsPassed()
        {
            return this.maxAndSumPassedCars.Item2;
        }

        public int getMaxPasPassed()
        {
            return this.maxAndSumPassedCars.Item1;
        }

        public int getAwaitingCarsCount()
        {
            return this.maxAndSumPassedCars.Item3;
        }
    }
}
