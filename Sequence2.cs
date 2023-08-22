using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSP_Assignment
{
    public partial class Sequence2 : UserControl
    {
        GSP Temp = new GSP(@"E:\Dataset.txt");
        public Sequence2()
        {
            InitializeComponent();
        }

        private void Sequence2_Load(object sender, EventArgs e)
        {
            char[] Candidate = Temp.SortCharArray(Temp.DistinctElements.ToCharArray());
            char[] Frequent = Temp.MakeFrequent1(Candidate, 2);

            String[,] Temporal = Temp.Candidate2_TemporalSequence(Frequent);
            String[] NonTemporal = Temp.Candidate2_NontemporalSequence(Frequent);

            for(int i = 0; i < Temporal.GetLength(0); i++)
            {
                for(int j = 0; j < Temporal.GetLength(1); j++)
                {
                    Temporal_lst.Items.Add(Temporal[i, j]);
                }
            }

            for(int i = 0; i < NonTemporal.Length; ++i)
            {
                Nontemporal_lst.Items.Add(NonTemporal[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] Candidate = Temp.SortCharArray(Temp.DistinctElements.ToCharArray());
            char[] Frequent = Temp.MakeFrequent1(Candidate, 2);

            String[,] Temporal = Temp.Candidate2_TemporalSequence(Frequent);
            String[] NonTemporal = Temp.Candidate2_NontemporalSequence(Frequent);

            String[] Frequent2 = Temp.MakeFrequent2(Temporal, NonTemporal);

            for(int i = 0; i < Frequent2.Length; i++)
            {
                Frequent2_lst.Items.Add(Frequent2[i]);
            }
        }
    }
}
