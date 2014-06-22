using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skrzyzowanie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            Lotto.seeduj();
            Application.EnableVisualStyles();

            GeneratorSkrzyzowania gs = new GeneratorSkrzyzowania();
            Skrzyzowanie s = gs.generujSkrzyzowanie(5,10, 10, 5, 3);
            Skrzyzowanie deepCopy = s.copy();

            SkrzyzowanieSolver solver = new SkrzyzowanieSolver();

            for (int i = 0; i < 10; i++) {
                int begin = Environment.TickCount;
                SolverProcess process = solver.solveSkrzyzowanie(s.copy());
                int delta = Environment.TickCount - begin;
                System.Console.WriteLine("Solving lasted:" + delta + " value of process:" + process.getProcessValue());
            }

            StreamWriter sw = new StreamWriter(Environment.TickCount.ToString() + ".csv");
            sw.Write("Liczba prob rozwiazania\tNajlepsze rozwiazanie\tIlosc zmian swiatel\tCzas rozwiazywania\n");
            Skrzyzowanie instancjaSkrzyzowania = gs.generujSkrzyzowanie(4, 20, 5, 3, 2);
            SolverProcess best = solver.solveSkrzyzowanie(instancjaSkrzyzowania.copy());

            for (int solvingTries = 1000; solvingTries < 10000100; solvingTries+=200000)
            {
                float bestValue = float.MinValue;
                SolverProcess process = null;

                int begining = Environment.TickCount;
                int delta = 0;
                long deltasum = 0;
                for (int i = 0; i < solvingTries; i++)
                {
                    Skrzyzowanie instancjaSkrzyzowaniaCopy = instancjaSkrzyzowania.copy();

                    begining = Environment.TickCount; // poczatek liczenia naszego skrzyzowania
                    process = solver.solveSkrzyzowanie(instancjaSkrzyzowaniaCopy);
                    delta = Environment.TickCount - begining; // koniec liczenia rozwiazania pojedynczego

                    float actual = process.getProcessValue();
                    if (actual > bestValue)
                    {
                        bestValue = actual;
                        best = process;
                    }
                    

                    deltasum += delta; // zsumowanie czasu np 1000 prob rozwiazania tej samej instancji
                }
                System.Console.WriteLine(solvingTries + "\t" + bestValue + "\t" + best.getSingalChangesCount() + "\t" + deltasum + "\n");

                sw.Write(solvingTries + "\t" + bestValue + "\t" + best.getSingalChangesCount() + "\t" + deltasum + "\n");

            }

            sw.Close();

        }
    }
}
