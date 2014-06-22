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
            sw.Write("Liczba prob rozwiazania\tAktualna najlepsza wartosc\tIlosc zmian swiatel\tCzas rozwiazywania\n");
            Skrzyzowanie instancjaSkrzyzowania = gs.generujSkrzyzowanie(4, 20, 5, 3, 2);
            SolverProcess best = solver.solveSkrzyzowanie(instancjaSkrzyzowania.copy());

            //for (int solvingTries = 1000; solvingTries < 10000100; solvingTries+=200000)
            {
                int solvingTries = 100;
                float bestValue = float.MinValue;
                SolverProcess process = null;

                Skrzyzowanie instancjaSkrzyzowaniaCopy = instancjaSkrzyzowania.copy();

                int begining = Environment.TickCount;
                for (int i = 0; i < solvingTries; i++)
                {
                    process = solver.solveSkrzyzowanie(instancjaSkrzyzowaniaCopy);
                    float actual = process.getProcessValue();
                    if (actual > bestValue)
                    {
                        bestValue = actual;
                        best = process;
                    }
                    if (i % 1 == 0)// && i != 0)
                    {
                        int delta = Environment.TickCount - begining;
                        //int delta = i;
                        System.Console.WriteLine(solvingTries + "\t" + bestValue + "\t" + actual + "\t" + best.getSingalChangesCount() + "\t" + delta + "\n");

                        sw.Write(solvingTries + "\t" + bestValue + "\t" + best.getSingalChangesCount() + "\t" + delta + "\n");
                    }
                }
            }

            sw.Close();

        }
    }
}
