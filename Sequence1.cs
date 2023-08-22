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
    public partial class Sequence1 : UserControl
    {
        GSP Temp = new GSP(@"E:\Dataset.txt");
        public Sequence1()
        {
            InitializeComponent();
        }

        private void Sequence1_Load(object sender, EventArgs e)
        {
            char[] Candidate = Temp.SortCharArray(Temp.DistinctElements.ToCharArray());
            for(int i = 0; i < Candidate.Length; i++)
            {
                if (Candidate[i] >= 'A' && Candidate[i] <= 'Z')
                    Candidate1_lst.Items.Add(Candidate[i] + "");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] Candidate = Temp.SortCharArray(Temp.DistinctElements.ToCharArray());
            char[] Frequent = Temp.MakeFrequent1(Candidate, 2);
            for (int i = 0; i < Frequent.Length; i++)
            {
                if (Frequent[i] >= 'A' && Frequent[i] <= 'Z')
                    Frequent1_lst.Items.Add(Frequent[i] + "");

            }
        }
    }
}
