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
    public partial class Sequence3 : UserControl
    {
        GSP Temp = new GSP(@"E:\Dataset.txt");
        public Sequence3()
        {
            InitializeComponent();
        }

        private void Sequence3_Load(object sender, EventArgs e)
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

            String[] First2_List = Temp.GenerateFirst(Frequent2);
            String[] Last2_List = Temp.GenerateLast(Frequent2);

            for(int i = 0; i < First2_List.Length; i++)
            {
                First_lst.Items.Add(First2_List[i]);
            }

            for (int i = 0; i < Last2_List.Length; i++)
            {
                Last_lst.Items.Add(Last2_List[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] Candidate = Temp.SortCharArray(Temp.DistinctElements.ToCharArray());
            char[] Frequent = Temp.MakeFrequent1(Candidate, 2);

            String[,] Temporal = Temp.Candidate2_TemporalSequence(Frequent);
            String[] NonTemporal = Temp.Candidate2_NontemporalSequence(Frequent);

            String[] Frequent2 = Temp.MakeFrequent2(Temporal, NonTemporal);

            String[] First2_List = Temp.GenerateFirst(Frequent2);
            String[] Last2_List = Temp.GenerateLast(Frequent2);

            String[] Candidate3 = Temp.GenerateHigherCandidate(Frequent2, First2_List, Last2_List);

            for(int i = 0; i < Candidate3.Length; ++i)
            {
                Candidate3_lst.Items.Add(Candidate3[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] Candidate = Temp.SortCharArray(Temp.DistinctElements.ToCharArray());
            char[] Frequent = Temp.MakeFrequent1(Candidate, 2);

            String[,] Temporal = Temp.Candidate2_TemporalSequence(Frequent);
            String[] NonTemporal = Temp.Candidate2_NontemporalSequence(Frequent);

            String[] Frequent2 = Temp.MakeFrequent2(Temporal, NonTemporal);

            String[] First2_List = Temp.GenerateFirst(Frequent2);
            String[] Last2_List = Temp.GenerateLast(Frequent2);

            String[] Candidate3 = Temp.GenerateHigherCandidate(Frequent2, First2_List, Last2_List);
            String[] Frequent3 = Temp.MakeFrequent(Candidate3);

            for(int i =0; i < Frequent3.Length; ++i)
            {
                Frequent3_lst.Items.Add(Frequent3[i]);
            }
        }
    }
}
