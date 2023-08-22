using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSP_Assignment
{
    internal class GSP
    {
        public String FileName;
        public String FileContent;
        public String DistinctElements;

        public GSP(String FName)
        {
            FileName = FName;
            FileContent = File.ReadAllText(FileName);
            DistinctElements = new String(FileContent.Distinct().ToArray());
        }

        // ***********************************************************************//


        // Special Functions


        // 1-Sequence Functions
        public char[] MakeFrequent1(char[] Candidate, int MinimumSupport)
        {
            int Size = 0;
            for (int i = 0; i < Candidate.Length; ++i)
            {
                if (Candidate[i] >= 'A' && Candidate[i] <= 'Z' && CalculateSupport(Candidate[i].ToString(), FileContent) >= MinimumSupport)
                    Size++;
            }

            char[] Frequent = new char[Size];
            int Count = 0;

            for (int i = 0; i < Candidate.Length; ++i)
            {
                if (Candidate[i] >= 'A' && Candidate[i] <= 'Z' && CalculateSupport(Candidate[i].ToString(), FileContent) >= MinimumSupport)
                    Frequent[Count++] = Candidate[i];
            }

            return Frequent;
        }

        // ----------------------------------------------------------------------//

        // 2-Sequence Functions
        public String[,] Candidate2_TemporalSequence(char[] Frequent_1)
        {
            int Size = Frequent_1.Length;
            String[,] TemporalSequence = new string[Size, Size];


            for (int i = 0; i < Size; ++i)
                for (int j = 0; j < Size; ++j)
                {
                    if (Frequent_1[i] >= 'A' && Frequent_1[j] <= 'Z')
                        TemporalSequence[i, j] = Frequent_1[i] + "-" + Frequent_1[j];


                }

            return TemporalSequence;
        }

        public String[] Candidate2_NontemporalSequence(char[] Frequent_1)
        {
            int Size = Frequent_1.Length;
            int SequenceSize = 0;
            for (int i = 1; i < Size; ++i)
            {
                SequenceSize += i;
            }
            String[] NontemporalSequence = new string[SequenceSize];
            int Count = 0;

            for (int i = 0; i < Size; ++i)
            {
                for (int j = 0; j < Size; ++j)
                {
                    if (j > i && (Frequent_1[i] >= 'A' && Frequent_1[i] <= 'Z') && (Frequent_1[j] >= 'A' && Frequent_1[j] <= 'Z'))
                    {
                        NontemporalSequence[Count++] = Frequent_1[i] + "" + Frequent_1[j];

                    }
                }
            }
            return NontemporalSequence;
        }

        public String[] MakeFrequent2(String[,] Temporal, String[] NonTemporal)
        {
            String[] Temporary = new String[Temporal.Length];
            int Count = 0;

            for (int i = 0; i < Temporal.GetLength(0); ++i)
            {
                for (int j = 0; j < Temporal.GetLength(1); ++j)
                {
                    if (CalculateSupport(Temporal[i, j], FileContent) >= 2)
                        Temporary[Count++] = Temporal[i, j];
                }
            }
            for (int i = 0; i < NonTemporal.Length; ++i)
            {
                if (CalculateSupport(NonTemporal[i], FileContent) >= 2)
                    Temporary[Count++] = NonTemporal[i];
            }

            String[] Frequent2_Sequence = new String[Count];
            for (int i = 0; i < Frequent2_Sequence.Length; ++i)
                Frequent2_Sequence[i] = Temporary[i];

            return Frequent2_Sequence;

        }


        // ----------------------------------------------------------------------//


        // General Functions


        // Helper Functions
        public char[] SortCharArray(char[] List)
        {
            Array.Sort(List);
            return List;
        }

        public bool IsSubSequence(String Sequence, String subsequence)
        {
            String[] OriginalSequence = Sequence.Split('-'); // B F G AB
            String[] OriginalSubSequence = subsequence.Split('-'); // A A

            int OriginalCount = OriginalSubSequence.Length; // 2
            int Count = 0;

            for (int i = 0; i < OriginalSequence.Length; ++i) // 3
            {
                if (OriginalSequence[i].Contains(OriginalSubSequence[Count])) //
                {
                    Count++;
                    if (Count == OriginalCount)
                        return true;
                }
            }

            return (Count == OriginalCount);
        }

        int CalculateSupport(String Input, String Sequences)
        {
            String[] SepearatedSequences = Sequences.Split(Environment.NewLine);
            int Support = 0;
            for (int i = 0; i < SepearatedSequences.Length; ++i)
            {

                if (Input.Length <= 2 && SepearatedSequences[i].Contains(Input))
                    Support++;
                else if (Input.Length > 2 && IsSubSequence(SepearatedSequences[i], Input))
                {
                    Support++;
                }
            }

            return Support;
        }

        // ----------------------------------------------------------------------//
        // GSP Functions
        public String[] GenerateHigherCandidate(String[] LowerSequence, String[] FirstList, String[] LastList)
        {

            String[] Temporary = new string[FirstList.Length * FirstList.Length];

            int Count = 0;
            for (int i = 0; i < FirstList.Length; ++i)
            {
                for (int j = 0; j < LastList.Length; ++j)
                {
                    if (i != j && FirstList[i] == LastList[j])
                    {
                        int Index = LowerSequence[j].Length - 1;
                        if (LowerSequence[j][Index - 1] == '-')
                        {
                            Temporary[Count++] = LowerSequence[i] + "-" + LowerSequence[j][Index];

                        }
                        else
                        {
                            Temporary[Count++] = LowerSequence[i] + LowerSequence[j][Index];
                        }


                    }
                }
            }

            String[] HigherSequence = new string[Count];

            for (int i = 0; i < HigherSequence.Length; ++i)
            {
                HigherSequence[i] = Temporary[i];
            }

            return HigherSequence;
        }

        public String[] GenerateFirst(String[] LowerSequence)
        {
            String[] FirstList = new string[LowerSequence.Length];


            for (int i = 0; i < LowerSequence.Length; ++i)
            {
                if (LowerSequence[i][1] == '-')
                {
                    for (int j = 2; j < LowerSequence[i].Length; ++j)
                    {
                        FirstList[i] += LowerSequence[i][j];
                    }
                }
                else
                {
                    /* FirstList[i] += ','; */
                    for (int j = 1; j < LowerSequence[i].Length; ++j)
                    {
                        FirstList[i] += LowerSequence[i][j];
                    }
                }

            }
            return FirstList;
        }

        public String[] GenerateLast(String[] LowerSequence)
        {
            string[] LastList = new string[LowerSequence.Length];

            for (int i = 0; i < LastList.Length; ++i)
            {
                int Index = LowerSequence[i].Length - 2;
                if (LowerSequence[i][Index] == '-')
                {
                    for (int j = 0; j < Index; ++j)
                    {
                        LastList[i] += LowerSequence[i][j];
                    }
                }

                else
                {
                    for (int j = 0; j < Index + 1; ++j)
                    {
                        LastList[i] += LowerSequence[i][j];
                    }
                    /*LastList[i] += ',';*/
                }
            }

            return LastList;
        }

        public String[] MakeFrequent(String[] Candidate)
        {
            int Count = 0;
            String[] Temporary = new string[Candidate.Length];

            for (int i = 0; i < Candidate.Length; ++i)
            {
                if (CalculateSupport(Candidate[i], FileContent) >= 2)
                {
                    Temporary[Count++] = Candidate[i];
                }
            }

            String[] FrequentSequence = new String[Count];

            for (int i = 0; i < Count; ++i)
            {
                FrequentSequence[i] = Temporary[i];
            }

            return FrequentSequence;
        }

        // ----------------------------------------------------------------------//
    }
}
