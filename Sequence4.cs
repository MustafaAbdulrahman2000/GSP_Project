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
    public partial class Sequence4 : UserControl
    {
        GSP Temp = new GSP(@"E:\Dataset.txt");
        public Sequence4()
        {
            InitializeComponent();
        }

        private void Sequence4_Load(object sender, EventArgs e)
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

            for(int i = 0; i < Frequent3.Length; ++i)
            {
                Frequent3_lst.Items.Add(Frequent3[i]);
            }

            String[] First3_List = Temp.GenerateFirst(Frequent3);
            String[] Last3_List = Temp.GenerateLast(Frequent3);

            for(int i = 0; i < First3_List.Length; ++i)
            {
                First_lst.Items.Add(First3_List[i]);
            }

            for(int i = 0; i < Last3_List.Length; ++i)
            {
                Last_lst.Items.Add(Last3_List[i]);
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
            String[] Frequent3 = Temp.MakeFrequent(Candidate3);

            String[] First3_List = Temp.GenerateFirst(Frequent3);
            String[] Last3_List = Temp.GenerateLast(Frequent3);

            String[] Candidate4 = Temp.GenerateHigherCandidate(Frequent3, First3_List, Last3_List);
            for(int i = 0; i < Candidate4.Length; i++)
            {
                Candidate4_lst.Items.Add(Candidate4[i]);
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

            String[] First3_List = Temp.GenerateFirst(Frequent3);
            String[] Last3_List = Temp.GenerateLast(Frequent3);

            String[] Candidate4 = Temp.GenerateHigherCandidate(Frequent3, First3_List, Last3_List);
            String[] Frequent4 = Temp.MakeFrequent(Candidate4);

            for(int i = 0; i < Frequent4.Length; ++i)
            {
                Frequent4_lst.Items.Add(Frequent4[i]);
            }
        }
    }
}
