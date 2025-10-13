using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Gaussian_distribution.ML
{
    public class Zone
    {
        private double x;
        private double y;
        private double dx;
        private double dy;
        private int exemples;

        public Zone(double x, double y, double dx, double dy, int exemples)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.exemples = exemples;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Dx
        {
            get { return dx; }
            set { dx = value; }
        }
        public double Dy
        {
            get { return dy; }
            set { dy = value; }
        }
        public int Exemples
        {
            get { return exemples; }
            set { exemples = value; }
        }
    }
}
