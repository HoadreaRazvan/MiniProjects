using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Gaussian_distribution.ML
{
    public class GenerateCoordinate
    {
        private Zone[] zones;
        private Random random;
        private string path;

        public GenerateCoordinate(string path)
        {
            this.path = path;
            File.WriteAllText(this.path+@"\Numbers.txt", string.Empty);

            this.random = new Random();
            this.zones = new Zone[] { new Zone(-180, -180, 10, 5, 400),
                                       new Zone(-180, 180, 5, 4, 400),
                                       new Zone( 180, 180, 5, 10, 400),
                                       new Zone(180, -180, 4, 10, 300),
                                       new Zone(0, 0, 5, 5, 300),
                                       new Zone(0, 200, 5,5, 200)
                                     };

            //this.zones = new Zone[] { new Zone(180, 220, 10, 10, 1000),
            //                           new Zone(-100, 110, 15, 10, 1000),
            //                           new Zone(210, -150, 5,20, 1000)
            //                         };
        }

        public void generatePoints()
        {
            int i = 0;
            for (int j = 0; j < 30000; j++)
            {
                i = random.Next(0, zones.Length);
                writeToFile(findPoint(zones[i].X, zones[i].Dx, -300, 300), findPoint(zones[i].Y, zones[i].Dy, -300, 300), i);
            }
        }

        public double findPoint(double m, double d, int min, int max)
        {
            double x, g, p;
            int k = 0;
            do
            {
                k++;
                x = random.Next(min, max);
                g = Math.Pow(Math.E, -((m - x) * (m - x)) / (2 * d * d));
                //p = random.NextDouble();
                p = random.Next(0, 100000) / 100000.0;
            } while (g < p);
            return x;
        }

        public void writeToFile(double number1, double number2, int i)
        {
            using (StreamWriter file = new StreamWriter(this.path+@"\Numbers.txt", true))
            {
                file.WriteLine(number1 + "," + number2 + "," + i);
            }
        }
    }
}
