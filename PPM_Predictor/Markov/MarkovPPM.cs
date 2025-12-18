using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov
{
    public class MarkovPPM
    {
        private int[] branches;
        private int m, hrg;
        private string pathFile;
        private bool completePPM;
        private Dictionary<string, int[]> patterns;
        private Random rand;

        private int correctPrediction;
        private int incorrectPrediction;
        private int branchesNumber;
        private double accuracy;
        private double dimness;
        private Dictionary<int, BranchInfo> branchInfo;

        public MarkovPPM(string pathFile, int m, int hrg, bool completePPM)
        {
            this.pathFile = pathFile;
            this.m = m;
            this.hrg = hrg;
            this.completePPM = completePPM;
            this.branches = new int[m + 1];
            this.patterns = new Dictionary<string, int[]>();
            this.rand = new Random();
            this.correctPrediction = 0;
            this.branchesNumber = 0;
            this.branchInfo = new Dictionary<int, BranchInfo>();

            this.generateMarkov();

        }


        public void generateMarkov()
        {
            string line, branchType, pattern;
            int[] count01 = new int[2] { 0, 0 };
            bool PPM = false;
            using (StreamReader read = new StreamReader(pathFile))
            {

                while ((line = read.ReadLine()) != null)
                {
                    this.shiftLeft(this.branches[m]);

                    branchType = line.Split(' ')[0];
                    if (branchType[0] == 'B')
                    {
                        this.branches[m] = 1;
                    }
                    else
                        if (branchType[0] == 'N')
                    {
                        this.branches[m] = 0;
                    }
                    count01[this.branches[m]]++;

                    int pc = int.Parse(line.Split(' ')[1]);
                    if (this.branchInfo.ContainsKey(pc) == false)
                    {
                        this.branchInfo.Add(pc, new BranchInfo());
                        this.branchInfo[pc].TotalAccesses++;
                    }
                    else
                    {
                        this.branchInfo[pc].TotalAccesses++;
                    }

                    if (this.branchesNumber >= m)
                    {

                        PPM = false;
                        for (int i = 0; i < m; i++)
                        {
                            pattern = "";
                            for (int j = i; j < m; j++)
                                pattern = pattern + branches[j];

                            if (this.branchesNumber < this.hrg)
                            {
                                if (this.patterns.ContainsKey(pattern))
                                {
                                    this.patterns[pattern][this.branches[m]]++;
                                }
                                else
                                {
                                    int[] counts = new int[2] { 0, 0 };
                                    counts[this.branches[m]]++;
                                    this.patterns.Add(pattern, counts);
                                }
                            }
                            else
                            {
                                if (this.patterns.ContainsKey(pattern) == true && (this.patterns[pattern][0] != this.patterns[pattern][1]))
                                {
                                    PPM = true;
                                    if (this.patterns[pattern][0] > this.patterns[pattern][1])
                                    {
                                        if (this.branches[m] == 0)
                                        {
                                            this.correctPrediction++;
                                            this.branchInfo[pc].CorrectPredictions++;
                                            this.patterns[pattern][0]++;
                                        }
                                        else
                                        {
                                            this.patterns[pattern][1]++;
                                        }
                                    }
                                    else
                                    {
                                        if (this.patterns[pattern][0] < this.patterns[pattern][1])
                                        {
                                            if (this.branches[m] == 1)
                                            {
                                                this.correctPrediction++;
                                                this.branchInfo[pc].CorrectPredictions++;
                                                this.patterns[pattern][1]++;
                                            }
                                            else
                                            {
                                                this.patterns[pattern][0]++;
                                            }
                                        }
                                        else
                                        if (this.patterns[pattern][0] == this.patterns[pattern][1])
                                        {
                                            int pred = this.rand.Next(0, 2);
                                            if (pred == this.branches[m])
                                            {
                                                this.correctPrediction++;
                                                this.branchInfo[pc].CorrectPredictions++;
                                                this.patterns[pattern][pred]++;
                                            }
                                            else
                                            {
                                                this.patterns[pattern][this.branches[m]]++;
                                            }
                                        }
                                    }
                                    for (int l = i + 1; l < m - 1; l++)
                                    {
                                        pattern = "";
                                        for (int j = 0 + i; j < m; j++)
                                            pattern = pattern + branches[j];
                                        if (this.patterns.ContainsKey(pattern) == true)
                                        {
                                            this.patterns[pattern][this.branches[m]]++;
                                        }
                                        else
                                        {
                                            int[] counts = new int[2] { 0, 0 };
                                            counts[this.branches[m]]++;
                                            this.patterns.Add(pattern, counts);
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    if (this.completePPM == false)
                                    {
                                        if (this.patterns.ContainsKey(pattern) == false)
                                        {
                                            int[] counts = new int[2] { 0, 0 };
                                            counts[this.branches[m]]++;
                                            this.patterns.Add(pattern, counts);
                                        }
                                        if (this.patterns[pattern][0] == this.patterns[pattern][1])
                                        {
                                            this.patterns[pattern][this.branches[m]]++;
                                        }

                                        if (count01[0] > count01[1])
                                        {
                                            if (this.branches[m] == 0)
                                            {
                                                correctPrediction++;
                                                this.branchInfo[pc].CorrectPredictions++;
                                                count01[0]++;
                                            }
                                            else
                                            {
                                                count01[1]++;
                                            }
                                        }
                                        else
                                        if (count01[0] < count01[1])
                                        {
                                            if (this.branches[m] == 1)
                                            {
                                                correctPrediction++;
                                                this.branchInfo[pc].CorrectPredictions++;
                                                count01[1]++;
                                            }
                                            else
                                            {
                                                count01[0]++;
                                            }
                                        }
                                        else
                                        {
                                            int pred = this.rand.Next(0, 2);
                                            if (pred == this.branches[m])
                                            {
                                                correctPrediction++;
                                                this.branchInfo[pc].CorrectPredictions++;
                                                count01[pred]++;
                                            }
                                            else
                                            {
                                                count01[this.branches[m]]++;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    if (this.completePPM == true)
                                    {
                                        if (this.patterns.ContainsKey(pattern) == false)
                                        {
                                            int[] counts = new int[2] { 0, 0 };
                                            counts[this.branches[m]]++;
                                            this.patterns.Add(pattern, counts);
                                        }
                                        if (this.patterns[pattern][0] == this.patterns[pattern][1])
                                        {
                                            this.patterns[pattern][this.branches[m]]++;
                                        }

                                    }
                                }
                            }

                        }
                        if (this.completePPM == true && PPM == false)
                        {
                            if (count01[0] > count01[1])
                            {
                                if (this.branches[m] == 0)
                                {
                                    this.correctPrediction++;
                                    this.branchInfo[pc].CorrectPredictions++;
                                    count01[0]++;
                                }
                            }
                            else
                            {
                                if (count01[0] < count01[1])
                                {
                                    if (this.branches[m] == 1)
                                    {
                                        this.correctPrediction++;
                                        this.branchInfo[pc].CorrectPredictions++;
                                        count01[1]++;
                                    }
                                }
                                else
                                {
                                    int pred = this.rand.Next(0, 2);
                                    if (pred == this.branches[m])
                                    {
                                        this.correctPrediction++;
                                        this.branchInfo[pc].CorrectPredictions++;
                                        count01[pred]++;
                                    }
                                }
                            }
                        }

                    }
                    this.branchesNumber++;
                }
            }

            this.branchesNumber = this.branchesNumber - this.hrg;
            this.accuracy = ((double)this.correctPrediction / this.branchesNumber) * 100;
            this.incorrectPrediction = this.branchesNumber - this.correctPrediction;
            this.dimness = 100 - this.accuracy;
            foreach (var pc in this.branchInfo.Keys)
            {
                this.branchInfo[pc].UpdatePercentageAccesses(this.branchesNumber);
                this.branchInfo[pc].UpdateIncorrectPredictions();
                this.branchInfo[pc].updateAccuracy();
                this.branchInfo[pc].UpdateDimness();
            }

            this.branchInfo = this.branchInfo.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }


        public void shiftLeft(int newValue)
        {
            for (int i = 0; i < m; i++)
            {
                this.branches[i] = this.branches[i + 1];
            }
            this.branches[m] = newValue;
        }

        public int CorrectPrediction { get { return this.correctPrediction; } }
        public int IncorrectPrediction { get { return this.incorrectPrediction; } }
        public int BranchesNumber { get { return this.branchesNumber; } }
        public double Accuracy { get { return this.accuracy; } }
        public double Dimness { get { return this.dimness; } }
        public Dictionary<int, BranchInfo> BranchInfo { get { return this.branchInfo; } }
    }
}
