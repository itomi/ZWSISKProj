using System;
using System.Collections.Generic;
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
        [STAThread]
        static void Main()
        {
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

        }
    }
}
