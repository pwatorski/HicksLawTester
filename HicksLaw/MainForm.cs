using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HicksLaw
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_begin_Click(object sender, EventArgs e)
        {
            Program.maxButtonsCurrent = (int)numUD_buttons.Value;
            Program.maxButtonsOverall = (int)numUD_buttons.Maximum;
            Program.numOfTries = (int)numUD_tries.Value;
            var m = new Measuring();
            m.Show();
        }
        public void UpdateResults(long[][] results)
        {
            var retStr = "C - choices\nT - test number\ntime to make a decision is represented in ms";
            var resultsInSconds = results.Select((c) => c.Select((t) => t / 1000f).ToArray()).ToArray();
            var sum = resultsInSconds.Select((c) => c.Sum());
            var avg = resultsInSconds.Select((c) => c.Sum() / c.Length).ToArray();
            var var = resultsInSconds.Zip(avg, (c, a) => c.Select((t) => (t - a) * (t - a)).Sum() / (c.Length)).ToArray();

            retStr += "\nT\\C\t" + string.Join("\t", Enumerable.Range(2, results.Length).Select((x) => $"{x}"));
            for(int t = 0; t < results[0].Length; t++)
            {
                retStr += $"\n{t + 1}.";
                for (int c = 0; c < resultsInSconds.Length; c++)
                {
                    retStr += $"\t{resultsInSconds[c][t].ToString("0.###")}";
                }
            }
            retStr += $"\navg.";
            for (int c = 0; c < avg.Length; c++)
            {
                retStr += $"\t{avg[c].ToString("0.###")}";
            }
            retStr += $"\nvar.";
            for (int c = 0; c < var.Length; c++)
            {
                retStr += $"\t{var[c].ToString("0.###")}";
            }
            rTB_results.Text = retStr;
        }
    }
}
                                                                                                                                                                  