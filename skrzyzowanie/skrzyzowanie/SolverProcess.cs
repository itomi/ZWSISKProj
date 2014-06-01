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
                float stepMultiplier = stepNumber;
                float currentPassed = currentStep.getCarsPassed();
                float maxPerPasPassed = currentStep.getMaxPasPassed();
                float awaitingCars = currentStep.getAwaitingCarsCount();

                float value = currentPassed/(awaitingCars*maxPerPasPassed);

                processValue += value;
            }
            return (float)(processValue / Math.Pow((double)listOfSteps.Count, 2.0));
        }
    }
}
