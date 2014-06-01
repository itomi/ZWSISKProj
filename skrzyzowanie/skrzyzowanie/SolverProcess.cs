using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class SolverProcess
    {
        Skrzyzowanie intancjaSkrzyzowania;
        ArrayList listOfSteps = new ArrayList();

        public SolverProcess(Skrzyzowanie skrzyzowanie) {
            this.intancjaSkrzyzowania = skrzyzowanie;
        }

        public void addStep(SolverStep step)
        {
            this.listOfSteps.Add(step);
        }

        public float getProcessValue() {
            float processValue = 0;
            for( int stepNumber = 0 ; stepNumber < listOfSteps.Count ; stepNumber++ ) {
                SolverStep currentStep = (SolverStep)listOfSteps[stepNumber];
                float currentPassed = currentStep.getCarsPassed();
                float maxPerPasPassed = currentStep.getMaxPasPassed();
                float awaitingCars = currentStep.getAwaitingCarsCount();

                float value = currentPassed/(( (Convert.ToBoolean(awaitingCars) ? awaitingCars: 1) * (Convert.ToBoolean(maxPerPasPassed) ? maxPerPasPassed :1 )));

                processValue += value;
            }
            float returrned = (float)(processValue / Math.Pow((double)listOfSteps.Count, 2.0));
            return returrned;
        }
    }
}
