using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Markov
{
    public class BranchInfo
    {
        private int totalAccesses;
        private double percentageAccesses;
        private int correctPredictions;
        private double accuracy;
        private int incorrectPredictions;
        private double dimness;

        public BranchInfo()
        {
            this.totalAccesses = 0;
            this.percentageAccesses = 0.0;
            this.correctPredictions = 0;
            this.accuracy = 0.0;
            this.incorrectPredictions = 0;
            this.dimness = 0.0;
        }

        public void UpdatePercentageAccesses(int totalBranches)
        {
            this.percentageAccesses = (double)totalAccesses / totalBranches * 100.0;
        }
        public void UpdateIncorrectPredictions()
        {
            this.incorrectPredictions = totalAccesses - correctPredictions;
        }
        public void updateAccuracy()
        {
            this.accuracy = (double)correctPredictions / totalAccesses * 100.0;
        }
        public void UpdateDimness()
        {
            this.dimness = (double)incorrectPredictions / totalAccesses * 100.0;
        }

        public int TotalAccesses
        {
            get { return totalAccesses; }
            set { totalAccesses = value; }
        }
        public double PercentageAccesses
        {
            get { return percentageAccesses; }
            set { percentageAccesses = value; }
        }
        public int CorrectPredictions
        {
            get { return correctPredictions; }
            set { correctPredictions = value; }
        }
        public double Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public int IncorrectPredictions
        {
            get { return incorrectPredictions; }
            set { incorrectPredictions = value; }
        }
        public double Dimness
        {
            get { return dimness; }
            set { dimness = value; }
        }
    }

}
