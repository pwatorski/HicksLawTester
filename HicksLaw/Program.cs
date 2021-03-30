using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HicksLaw
{
    static class Program
    {

        public static int maxButtonsCurrent;
        public static int maxButtonsOverall = 10;
        public static int numOfTries = 0;
        static Form1 main;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(main = new Form1());
        }

        public static void UpdateResults(long[][] results)
        {
            main.UpdateResults(results);
        }
    }
}
